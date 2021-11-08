using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearingCalculator.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var diameter = ReadIntFromConsole("Geben Sie den Reifendurchmesser in mm ein");
            
            //Eingabe der Anzahl an Kettenblättern und der einzelnen Zähnezahlen
            //Zähnezahlen werden in Liste gespeichert
            var numFrontGears = ReadIntFromConsole("Geben Sie die Anzahl an Kettenblättern ein");
            var frontGears = new List<int>(numFrontGears);
            for (var i = 1; i <= numFrontGears; i++)
                frontGears.Add(ReadIntFromConsole($"Geben Sie die Zähnezahl von Kettenblatt {i} ein")); //$ vor String ist interpolated string, d.h. in { } können Ausdrücke & Variablen verwendet werden
            
            //Analog zu Kettenblätter
            var numRearGears = ReadIntFromConsole("Geben Sie die Anzahl an Ritzeln ein");
            var rearGears = new List<int>(numRearGears);
            for (var i = 1; i <= numRearGears; i++)
                rearGears.Add(ReadIntFromConsole($"Geben Sie die Zähnezahl von Ritzel {i} ein"));

            var currentFrontGear = 1;
            var frequency = 70; //rpm, Trittfrequenz
            //verschachtelte Schleifen zum Ausgeben aller Möglichen Übersetzungsverhältnisse
            foreach (var frontGear in frontGears)
            {
                Console.WriteLine($"Kettenblatt {currentFrontGear}");
                foreach (var rearGear in rearGears) 
                {
                    var i = (double)frontGear / rearGear;
                    Console.WriteLine($"i:{i,-7:N2} v:{(double)diameter / 1000 * Math.PI * i * frequency / 60 * 3.6:N2} km/h");
                    //i,-7:N2 => auf string mit Länge 7 mit Leerzeichen nach rechts auffüllen, N2 formatiert double Werte zu strings mit 2 Nachkommastellen
                }
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Methode um auf sichere Art und Weise int vom User einzulesen
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        static int ReadIntFromConsole(string message)
        {
            int retValue;
            string input;
            do
            {
                if (!string.IsNullOrWhiteSpace(message))
                    Console.WriteLine(message);

                input = Console.ReadLine();
            }
            while (!int.TryParse(input, out retValue));

            return retValue;
        }
    }
}
