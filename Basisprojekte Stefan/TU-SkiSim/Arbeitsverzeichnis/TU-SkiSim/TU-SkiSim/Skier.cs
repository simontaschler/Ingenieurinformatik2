using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TU_SkiSim
{
    public abstract class Skier
    {
        private int arrivingTime;
        private int leavingTime;
        private int number;
        protected int skillLevel;
        private int status;
        private int timeToNextStep;
        private List<Lift> usedLifts;
        private List<Track> usedTracks;
        protected int velocity;
        protected int visitedHuts;
        private int waitingNumber;

        protected Skier(int number, int arrivingTime)
        {
            throw new System.NotImplementedException();
        }

        public virtual int calculateNeededTime(Track akt_Strecke)
        {
            throw new System.NotImplementedException();
        }

        public abstract Track calculateNextTrack(string alle_Strecken)
        {
            throw new System.NotImplementedException();
        }

        public void countDownTime()
        {
            throw new System.NotImplementedException();
        }

        public int getArrivingTime()
        {
            throw new System.NotImplementedException();
        }

        public int getLeavingTime()
        {
            throw new System.NotImplementedException();
        }

        public int getNumber()
        {
            throw new System.NotImplementedException();
        }

        public abstract double getProbabilityHut()
        {
            throw new System.NotImplementedException();
        }

        public int getStatus()
        {
            throw new System.NotImplementedException();
        }

        public int getTimeToNextStep()
        {
            throw new System.NotImplementedException();
        }

        public List<Lift> getUsedLifts()
        {
            throw new System.NotImplementedException();
        }

        public List<Track> getUsedTracks()
        {
            throw new System.NotImplementedException();
        }

        public List<Hut> getVisitedHuts()
        {
            throw new System.NotImplementedException();
        }

        public int getWaitingNumber()
        {
            throw new System.NotImplementedException();
        }

        public void setLeavingTime(int set_leaving_time)
        {
            throw new System.NotImplementedException();
        }

        public void setStatus(string set_status)
        {
            throw new System.NotImplementedException();
        }

        public void setTimeToNextStep(string set_time)
        {
            throw new System.NotImplementedException();
        }

        public void setUsedLift(Lift lift)
        {
            throw new System.NotImplementedException();
        }

        public void setUsedTrack(string strecke)
        {
            throw new System.NotImplementedException();
        }

        public void setVisitedHut(string huette)
        {
            throw new System.NotImplementedException();
        }

        public void setWaitingNumber(string set_waitingnumber)
        {
            throw new System.NotImplementedException();
        }

        public string ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}