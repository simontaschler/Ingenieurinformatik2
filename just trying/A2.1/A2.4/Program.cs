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

            Console.ReadLine();
                
           
        }
    }
}
