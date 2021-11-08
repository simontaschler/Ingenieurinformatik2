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
            //Logik zum Laden der Batterie
            //sorgt dafür, dass keine Ladung durch negative Werte abgezogen werden kann und dass nicht über 100% geladen werden kann
            if (rechargeLevel < 0)
                return;
            else if (rechargeLevel + Charge > 100)
                Charge = 100;
            else
                Charge += rechargeLevel;
        }

        internal void Consume(double consumedCharge)
        {
            //Logik zum Verbrauchen der Batterieladung
            //sorgt dafür, dass keine Ladung durch negative Werte hinzugefügt werden kann und dass nicht unter 0% entladen werden kann
            if (consumedCharge < 0)
                return;
            else if (Charge - consumedCharge < 0)
                Charge = 0;
            else
                Charge -= consumedCharge;
        }
    }
}
