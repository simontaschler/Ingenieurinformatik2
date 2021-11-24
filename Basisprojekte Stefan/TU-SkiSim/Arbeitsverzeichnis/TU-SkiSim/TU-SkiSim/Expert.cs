using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TU_SkiSim
{
    public class Expert : Skier
    {
        private double propHutBasic;
        public Expert(int number, int arrivingTime) : base(number, arrivingTime)
        {
        }

        public int calculateNeededTime(Track akt_Strecke)
        {
            throw new System.NotImplementedException();
        }
        public Track calculateNextTrack(List<Track> alle_Strecken)
        {
            throw new System.NotImplementedException();
        }

        public double getProbabilityHut()
        {
            throw new System.NotImplementedException();
        }
    }
}