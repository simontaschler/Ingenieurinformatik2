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
        {Console.OutputEncoding = System.Text.Encoding.UTF8;        //Festlegen des UTF8 Standards in der Konsole (um das € Symbol später ausgeben zu können)
            #region Zahlen_Sortierung
            Console.WriteLine("Zahlenmengen sortieren:");
            List<int> Zahlenmenge = new List<int>                   //Erstrellen einer Liste mit ungeordneten Zahlen
            {
                1,
                435,
                3452,
                5,
                90,
                69,
                33
            };               


            Zahlenmenge.Sort();     //Die sort Methode von Listen sortiert in aufsteigender Reihenfolge

            foreach(var Zahl in Zahlenmenge)        //output jedes Elementes der Liste 
            {
                Console.WriteLine(Zahl);
            }

            Console.Write("\n");

            Zahlenmenge.Reverse();          //Reverse ändert die Riehenfolge der Elemente der Liste

            foreach(var Zahl in Zahlenmenge)
            {
                Console.WriteLine(Zahl);        //output über die Konsole
            }

            Console.WriteLine("\n*******************************\n");
            #endregion            

            #region Handybeispiel
            Console.WriteLine("Handy Beispiel:\n");

            List<Handy> Handyliste = new List<Handy> { new Handy("iPhone 8", 479.99),       //Anlegen einer Liste welche Objekte des Typs Handy aufnimmt
                new Handy("Galaxy S9", 620.88),
                new Handy("iPhone 11", 479.99),
                new Handy("Nokia 3310", 69.95)
            };

            Handyliste.Sort();              //Durch diesen Aufruf wird die im Objekt Handy implizierte Compare Methode (IComparable) aufgerufen
            foreach(var n in Handyliste)
            {
                Console.WriteLine(n);       //Output über die Konsole
            }


            Console.WriteLine("\niCompare Methode:");
            Handyliste.Sort(new Handy_Comparer());      //Durch die Angabe einer gewünschten Sortiermethode, kann die Standradmäßige umgangen werden
                                                        //In diesem Fall wird hier ein neues Objekt erstellt welches das Compare Interface eingebunden hat
            foreach(var n in Handyliste)
            {
                Console.WriteLine(n);           //Output über die Konsole
            }

            #endregion
           
            Console.Read();

        }
    }
}
