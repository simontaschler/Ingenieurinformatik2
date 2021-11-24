using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TU_SkiSim
{
    public abstract class Lift
    {
        protected int elements;
        protected int length;
        protected int number;
        protected int velocity;
        private int waitingQueue;

        protected Lift(int number, int velocity, int length, int elements)
        {
            throw new System.NotImplementedException();
        }

        public void addQueue()
        {
            throw new System.NotImplementedException();
        }

        public abstract int calcFlowRate()
        {
            throw new System.NotImplementedException();
        }

        public int getNumber()
        {
            throw new System.NotImplementedException();
        }

        public int getTravelTime()
        {
            throw new System.NotImplementedException();
        }

        public int getWaitingQueue()
        {
            throw new System.NotImplementedException();
        }

        public void redWaitingQueue()
        {
            throw new System.NotImplementedException();
        }
    }
}