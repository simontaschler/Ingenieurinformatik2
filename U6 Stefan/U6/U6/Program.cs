using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U6
{
    class Program
    {
        static void Main(string[] args)
        {Console.OutputEncoding = System.Text.Encoding.UTF8;
            #region Zahlen_Sortierung
            Console.WriteLine("Zahlenmengen sortieren:");
            List<int> Zahlenmenge = new List<int>();

            Zahlenmenge.Add(1);
            Zahlenmenge.Add(435);
            Zahlenmenge.Add(3452);
            Zahlenmenge.Add(5);
            Zahlenmenge.Add(90);
            Zahlenmenge.Add(69);
            Zahlenmenge.Add(33);


            Zahlenmenge.Sort();

            foreach(var Zahl in Zahlenmenge)
            {
                Console.WriteLine(Zahl);
            }

            Console.Write("\n");

            Zahlenmenge.Reverse();

            foreach(var Zahl in Zahlenmenge)
            {
                Console.WriteLine(Zahl);
            }

            Console.WriteLine("\n*******************************\n");
            #endregion            

            #region Handybeispiel
            Console.WriteLine("Handy Beispiel:\n");

            List<Handy> Handyliste = new List<Handy> { new Handy("iPhone 8", 479.99),
                new Handy("Galaxy S9", 620.88),
                new Handy("iPhone 11", 479.99),
                new Handy("Nokia 3310", 69.95)
            };

            Handyliste.Sort();
            foreach(var n in Handyliste)
            {
                Console.WriteLine(n);
            }


            Console.WriteLine("\niCompare Methode:");
            Handyliste.Sort(new Handy_Comparer());

            foreach(var n in Handyliste)
            {
                Console.WriteLine(n);
            }

            #endregion
           
            Console.Read();

        }
    }
}
