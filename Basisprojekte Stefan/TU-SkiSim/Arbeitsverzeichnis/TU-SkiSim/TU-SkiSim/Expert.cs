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

        public override int calculateNeededTime(Track akt_Strecke)
        {
            throw new System.NotImplementedException();
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