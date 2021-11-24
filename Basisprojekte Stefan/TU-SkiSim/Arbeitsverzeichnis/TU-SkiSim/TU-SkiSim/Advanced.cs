using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TU_SkiSim
{
    public class Advanced : Skier
    {
        private double propHutBasic;
        public Advanced(int number, int arrivingTime) : base(number, arrivingTime)
        {
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