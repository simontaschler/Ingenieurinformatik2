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
            
            var numFrontGears = ReadIntFromConsole("Geben Sie die Anzahl an Kettenblättern ein");
            var frontGears = new List<int>(numFrontGears);
            for (var i = 1; i <= numFrontGears; i++)
                frontGears.Add(ReadIntFromConsole($"Geben Sie die Zähnezahl von Kettenblatt {i} ein"));
            
            var numRearGears = ReadIntFromConsole("Geben Sie die Anzahl an Ritzeln ein");
            var rearGears = new List<int>(numRearGears);
            for (var i = 1; i <= numRearGears; i++)
                rearGears.Add(ReadIntFromConsole($"Geben Sie die Zähnezahl von Ritzel {i} ein"));

            var currentFrontGear = 1;
            var frequency = 70;
            foreach (var frontGear in frontGears)
            {
                Console.WriteLine($"Kettenblatt {currentFrontGear}");
                foreach (var rearGear in rearGears) 
                {
                    var i = (double)frontGear / rearGear;
                    Console.WriteLine($"i:{i,-7:N2} v:{(double)diameter / 1000 * Math.PI * i * frequency / 60 * 3.6:N2} km/h");
                }
            }

            Console.ReadLine();
        }

        static int ReadIntFromConsole(string message = null)
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
