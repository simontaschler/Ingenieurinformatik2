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

       

        public override Track calculateNextTrack(string alle_Strecken)
        {
            throw new NotImplementedException();
        }

        public override double getProbabilityHut()
        {
            throw new NotImplementedException();
        }
    }
}