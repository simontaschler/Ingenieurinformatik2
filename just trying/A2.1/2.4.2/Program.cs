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
            int a = int.Parse(input);


            if (a == 1)
            {
                a = a + 1;
                Console.WriteLine("a=" + a);
            }
            else
            {
                if (a == 2)
                {
                    a = a % 2;
                    Console.WriteLine("a=" + a);
                }
                else
                {
                    if (a == 3)
                    {
                        a = a / 2;
                        Console.WriteLine("a=" + a);
                    }
                    else
                    {
                        if (a == 4)
                        {
                            var converteda = (double)a;
                            converteda = Math.Pow(a, 32);
                            Console.WriteLine("a=" + converteda.ToString("N0"));

                        }
                        else
                        {
                            Console.WriteLine("Nicht definiert");
                        }
                    }
                }
            }

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
