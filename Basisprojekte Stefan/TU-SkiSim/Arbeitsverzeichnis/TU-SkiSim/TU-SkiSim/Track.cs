using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TU_SkiSim
{
    public class Track
    {
        private int capacity;
        private Hut hut;
        private int length;
        private int level;
        private int lift;
        private int number;
        private int peopleOnTheTrack;
        private int workload;

        public Track(int nummer, int länge, int level, Hut huette, int kapazität, string lift_der_Strecke)
        {
            throw new System.NotImplementedException();
        }

        public Track(int nummer, int länge, int level, int kapazität, string lift_der_Strecke)
        {
            throw new System.NotImplementedException();
        }

        public double calcWorkload()
        {
            throw new System.NotImplementedException();
        }

        public void changePeopleOnTheTrack(string Anzahl)
        {
            throw new System.NotImplementedException();
        }

        public Hut getHut()
        {
            throw new System.NotImplementedException();
        }

        public int getLength()
        {
            throw new System.NotImplementedException();
        }

        public int getLevel()
        {
            throw new System.NotImplementedException();
        }

        public Lift getLift()
        {
            throw new System.NotImplementedException();
        }

        public int getNumber()
        {
            throw new System.NotImplementedException();
        }

        public int getPeopleOnTheTrack()
        {
            throw new System.NotImplementedException();
        }
    }
}