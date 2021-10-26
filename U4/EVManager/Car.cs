using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVManager
{
    internal class Car
    {
        private double consumptionFactor;
        private Battery battery;

        internal string Brand { get; }
        internal double Charge => battery.Charge;

        internal Car(string brand, double consumptionFactor, Battery battery = null)
        {
            Brand = brand;
            this.consumptionFactor = consumptionFactor;
            this.battery = battery ?? new Battery();
        }

        internal void Drive(int km)
        {
            double travelledDistance = 0;
            var chargeToConsume = km * consumptionFactor;

            Console.Clear();
            Console.WriteLine($"{Brand} beginnt zu fahren");

            while (battery.Charge - chargeToConsume <= 10)
            {
                var drivenKm = (battery.Charge - 10) / consumptionFactor;
                battery.Consume(drivenKm * consumptionFactor);
                travelledDistance += drivenKm;
                chargeToConsume = (km - travelledDistance) * consumptionFactor;

                Console.WriteLine($"{travelledDistance:N1} von {km} km zurückgelegt. Batteriestand nur noch bei 10%.");
                Console.WriteLine("Wie viel möchten sie aufladen?");
                var recharge = ReadIntFromConsole();
                battery.Recharge(recharge);
            }

            battery.Consume(chargeToConsume);
            Console.WriteLine($"Komplette Distanz von {km} km zurückgelegt. Verbleibender Batteriestand: {battery.Charge:N1} %");
            Console.ReadLine();
        }

        private static int ReadIntFromConsole()
        {
            int retValue;
            string input;
            do
            {
                input = Console.ReadLine();
            }
            while (!int.TryParse(input, out retValue) && retValue > 0);

            return retValue;
        }
    }
}
