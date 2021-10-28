using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie einen Parameter a als Integer ein um fortzufahren");
            var input = Console.ReadLine();
            double a = int.Parse(input);
            var isinRange = a >= 1 && a <= 4;

            switch (a)
            {
                case 1: a++; break;
                //a++ meint "a um Eines größer"
                case 2: a = a % 2; break;
                case 3: a = (int)(a / 2); break;
                //Nachkommastelle(n) werden ignoriert und verworfen durch ganzzahligen Datentyp
                case 4: a = Math.Pow(a, 32); break;
                //4^32 = 2^64, was größer als MaxValue vom standardmäßigen Int32 ist
                //auch höchste MaxValue eines ganzzahligen Datentyps UInt64 ist nur 2^64 - 1,
                //deshalb muss double verwendet werden
                default: Console.WriteLine("Error: Your input is out of bounds"); break;
            }

            if (isinRange)
                Console.WriteLine($"a = {a.ToString("N0")}");

            // converted a fehlt aber da 4^32 immer gerade ist (modulo = 0) stimmt das Ergebnis der Abfrage b trotzdem)

            Console.WriteLine("Geben Sie einen Paramaeter b als Integer ein um fortzufahren");

            var binput = Console.ReadLine();
            var b = int.Parse(binput);

            if (a % 2 == 0)
            {
                Console.WriteLine("Gerade");
            }
            else
            {
                Console.WriteLine("Ungerade");
                if (a > b)
                {
                    Console.WriteLine("a ist größer als b");
                }
                else
                {
                    Console.WriteLine("logisch richtige Aussage");
                }

            }

            Console.ReadLine();


        }
    }
}
