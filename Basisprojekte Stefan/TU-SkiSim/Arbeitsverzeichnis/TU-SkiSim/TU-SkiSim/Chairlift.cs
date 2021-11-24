using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TU_SkiSim
{
    public class Chairlift : Lift
    {
        private int seats;

        public Chairlift(int number, int velocity, int length,double ausfallswsl, int elements, int anzahl_sitze) : base(number, velocity, length, elements)
        {
        }

        public int calcFlowRate()
        {
            throw new System.NotImplementedException();
        }
    }
}