using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TU_SkiSim
{
    public class Beginner : Skier
    {
        private double propHutBasic;

        public Beginner(int number, int arrivingTime) : base(number, arrivingTime)
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