using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowchart.B.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 1;

            while (a < 5)
            {
                Console.WriteLine($"Äußere Schleife: a = {a}");
                while (b < 5)
                {
                    if (b == 3)
                    {
                        Console.WriteLine("Innere Schleife: continue");
                        continue;
                        //führt zu Endlosschleife
                    }
                    Console.WriteLine($"Innere Schleife: b = {b}");
                    b++;
                }
                a++;
                b = 1;
            }
        }
    }
}
