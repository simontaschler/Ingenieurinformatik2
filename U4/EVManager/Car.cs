using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVManager
{
    internal class Car
    {
        private readonly double ConsumptionFactor;
        private readonly Battery Battery;

        //Auto-Property, nur get: MSBuild generiert im Hintergrund privates readonly Feld zum Speichern des Wertes und Methode get_Brand() zur Rückgabe dessen, wird in Syntax aber wie Variable verwendet
        internal string Brand { get; }
        //Property mit Expression-Body: im Hintergrund Methode get_Charge() die Battery.Charge zurückgibt, Syntax bei Aufruf wie Variablenzugriff
        internal double Charge => Battery.Charge;

        internal Car(string brand, double consumptionFactor, Battery battery = null /*optionaler Parameter, wenn nicht bei Aufruf übergeben, wird Wert hinter = zugewiesen*/)
        {
            Brand = brand;
            ConsumptionFactor = consumptionFactor;
            Battery = battery ?? new Battery(); //Wenn Ausdruck links von ?? null ist wird Ausdruck rechts verwendet
        }

        internal void Drive(int km)
        {
            double travelledDistance = 0;   //Variable für die bereits zurückgelegte Distanz
            var chargeToConsume = km * ConsumptionFactor;   //für gesamte Strecke benötigte Batterieladung, evtl. > 100

            Console.Clear();
            Console.WriteLine($"{Brand} beginnt zu fahren");

            while (Battery.Charge - chargeToConsume <= 10)  //Lade- und Entladezyklus wird solange wiederholt bis Distanz mit mind. 10% Restladung zurückgelegt werden kann
            {
                var drivenKm = (Battery.Charge - 10) / ConsumptionFactor;       //km die bis 10% Batteriestand zurückgelegt werden können
                Battery.Consume(drivenKm * ConsumptionFactor);                  //Batterieladung verbrauchen
                travelledDistance += drivenKm;                                  //zurückgelegte Distanz aktualisieren
                chargeToConsume = (km - travelledDistance) * ConsumptionFactor; //für restliche Strecke benötigte Ladung berechnen

                Console.WriteLine($"{travelledDistance:N1} von {km} km zurückgelegt. Batteriestand nur noch bei 10%.");
                Console.WriteLine("Wie viel möchten sie aufladen?");
                var recharge = ReadIntFromConsole();
                Battery.Recharge(recharge); //Batterie um benutzerdefinierten Betrag aufladen
            }

            Battery.Consume(chargeToConsume);   //Batterieladung für noch zu fahrende Distanz verbrauchen
            Console.WriteLine($"Komplette Distanz von {km} km zurückgelegt. Verbleibender Batteriestand: {Battery.Charge:N1} %");
            Console.ReadLine();
        }

        /// <summary>
        /// Abfangen von ungültigem Input beim Einlesen von int
        /// </summary>
        /// <returns></returns>
        private static int ReadIntFromConsole()
        {
            int retValue;
            string input;
            do
            {
                input = Console.ReadLine();
            }
            while (!int.TryParse(input, out retValue) && retValue > 0); //TryParse gibt true zurück wenn input in int geparsed werden kann, geparster Wert wird über out-Parameter zurückgegeben

            return retValue;
        }
    }
}
