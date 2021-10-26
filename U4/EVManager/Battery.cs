using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVManager
{
    internal class Battery
    {
        internal double Charge { get; private set; }

        internal Battery() =>
            Charge = 100;

        internal void Recharge(double rechargeLevel)
        {
            if (rechargeLevel < 0)
                return;
            else if (rechargeLevel + Charge > 100)
                Charge = 100;
            else
                Charge += rechargeLevel;
        }

        internal void Consume(double consumedCharge)
        {
            if (consumedCharge < 0)
                return;
            else if (Charge - consumedCharge < 0)
                Charge = 0;
            else
                Charge -= consumedCharge;
        }
    }
}
