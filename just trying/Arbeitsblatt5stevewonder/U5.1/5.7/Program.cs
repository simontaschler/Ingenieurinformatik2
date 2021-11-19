using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Fahrrad Fahrrad1 = new Rennrad(8, 27, 1, 2);
            Fahrrad Fahrrad2 = new EBike(5, 24, 1, 2500);
            Fahrrad Fahrrad3 = new Fahrrad(9, 26, 1);

            Fahrrad[] fahrradarray = new Fahrrad[] { Fahrrad1, Fahrrad2, Fahrrad3 };

            int count = 1;
            foreach (Fahrrad rad in fahrradarray)
            {
                Console.WriteLine("\n***********************\nFahrrad" + count + ":\n");
                for (int i = 0; i < 2000; i += 10) 
                {
                    double Verschleiss = rad.Verschleissrechner(i);
                    Console.WriteLine("km " + i + ": Verschleiss: " + Verschleiss);
                    if (Verschleiss==0.8)
                    {
                        Console.WriteLine("****************Achtung! Verschleisswert liegt bei 0,8!****************");
                    }
                    else if (Verschleiss >= 0.95)
                    {
                        Console.WriteLine("*************************\nFahrrad wird verschrottet! Kilometerstand: " + i);
                        break;
                    }
                }
                Console.WriteLine("Press any key to calculate the next Bike!");
                Console.ReadLine();
                Console.Clear();
                count++;
                
                
            }
            Console.WriteLine("There is no other Bike in the Array!");
            Console.Read();
        }
    }
}
