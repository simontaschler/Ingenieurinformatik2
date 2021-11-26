using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TU_SkiSim
{
    public class Simulation
    {
        private List<Lift> addedLifts;
        private List<Skier> addedSkier;
        private List<Track> addedTracks;
        private bool status;

        public Simulation(List<Lift> lifte, List<Skier> schifahrer, List<Hut> huetten, List<Track> strecken)
        {
            this.addedLifts = lifte;
            this.addedSkier = schifahrer;
            this.addedTracks = strecken;            
        }

        public List<Lift> getLifts()
        {
            return addedLifts;
        }

        public List<Skier> getSkier()
        {
            return addedSkier;
        }

        public List<Track> getTracks()
        {
            return addedTracks;
        }

        public void simulate(int startzeit, int endzeit)
        {
        
            status = false;
            int Zeit = startzeit * 60;
            while (Zeit <= endzeit * 60)
            {
                int anzahlSkifahrer = addedSkier.Count();
                foreach (Skier n in addedSkier)
                {
                    if (n.getStatus() != Status.leftResort && n.getTimeToNextStep() == 0 && Zeit >= n.getArrivingTime())
                    {
                        switch (n.getStatus())
                        {
                            case Status.vorLift:
                                enterResort(n);
                                break;
                            case Status.inLift:                               
                                    skierOnLift(n, Zeit, endzeit);                               
                                break;                           
                            default:
                                sonnstigerStatus(n);
                                break;
                        }
                    }
                    else if (n.getStatus() == Status.leftResort && n.getTimeToNextStep() == 0)
                    {
                        n.setLeavingTime(Zeit);
                    }
                   
                    n.countDownTime();

                    foreach (Lift lift in addedLifts)
                    {
                        lift.redWaitingQueue();
                    }                
                }
            




            }
            status = false;
            Console.WriteLine("Simulation beendet");
        }

        private Lift getLift1()
        {
            return addedLifts.FirstOrDefault(q => q.getNumber() == 1);
        }
        private void enterResort(Skier skifahrer)
        {
            if (getLift1().calcFlowRate()>= skifahrer.getWaitingNumber())
            {
                skifahrer.setUsedLift(getLift1());
                skifahrer.setStatus(Status.inLift);
                skifahrer.setTimeToNextStep(getLift1().getTravelTime());
                skifahrer.setWaitingNumber(0);
            }
            else
            {
                skifahrer.setWaitingNumber(skifahrer.getWaitingNumber() - getLift1().calcFlowRate());
            }
        }
        private void skierOnLift(Skier skifahrer, int zeit, int endzeit)
        {
            if (zeit < endzeit - 90)
            {
                Track nextTrack = skifahrer.calculateNextTrack(getTracks());
                skifahrer.setUsedTrack(nextTrack);
                nextTrack.changePeopleOnTheTrack(nextTrack.getPeopleOnTheTrack() + 1);
                skifahrer.setStatus(Status.inTrack);
                skifahrer.setTimeToNextStep(skifahrer.calculateNeededTime(nextTrack));
                if (nextTrack.getHut() != null)
                {
                    Random rnd = new Random();
                    if (skifahrer.getProbabilityHut() > rnd.NextDouble() && nextTrack.getHut().getGuests() < nextTrack.getHut().getMaxGuests())
                    {
                        skifahrer.setTimeToNextStep(nextTrack.getHut().getAverageStay());
                        skifahrer.setVisitedHut(nextTrack.getHut());
                        nextTrack.getHut().addGuests(1);
                    }
                }
            }
            else
            {
                
                skifahrer.setStatus(Status.leftResort);
                Track nextTrack = skifahrer.calculateNextTrack(getTracks().Where(q => q.getNumber() == 1 || q.getNumber() == 2).ToList());
                int abfahrtszeit = skifahrer.calculateNeededTime(nextTrack);
                skifahrer.setUsedTrack(nextTrack);
                nextTrack.changePeopleOnTheTrack(nextTrack.getPeopleOnTheTrack() + 1);
                skifahrer.setTimeToNextStep(abfahrtszeit);
                skifahrer.setLeavingTime(zeit + abfahrtszeit);
            }
        }
        private void sonnstigerStatus(Skier skifahrer)
        {
            Lift nextlift = skifahrer.getUsedTracks().Last().getLift();                     
            nextlift.addQueue();
            skifahrer.setWaitingNumber(nextlift.getWaitingQueue());
            
            if ((nextlift.calcFlowRate() >= skifahrer.getWaitingNumber()))
            {
                skifahrer.setStatus(Status.inLift);
                skifahrer.setUsedLift(nextlift);
                skifahrer.setTimeToNextStep(nextlift.getTravelTime());
                skifahrer.setWaitingNumber(0);
                Track lastTrack = skifahrer.getUsedTracks().Last();
                lastTrack.changePeopleOnTheTrack(lastTrack.getPeopleOnTheTrack() - 1);
            }
            else
            {
                skifahrer.setWaitingNumber(skifahrer.getWaitingNumber() - getLift1().calcFlowRate());
            }
        }
    }
}