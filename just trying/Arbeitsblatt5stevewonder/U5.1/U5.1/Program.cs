using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zirkusobjekt erstellen durch Aufrufen des Konstruktors
          var zirkus1 = new Zirkus("HalliGalli", 5, new Tiertrainer("Klaus Müller"));

            //Tier Objekte mittels Konstruktor erstellen und direkt in das zirkus Objekt hinzufügen
         zirkus1.Tierhinzufügen(new Tier("Klaus", "Pferd"));
         zirkus1.Tierhinzufügen(new Tier("Herbert", "Maus"));
         zirkus1.Tierhinzufügen(new Tier("Herbert", "Eintagsfliege"));
         zirkus1.Tierhinzufügen(new Tier("Samy", "Hund"));
         zirkus1.Tierhinzufügen(new Tier("Günther", "Regenbogenforelle"));
         zirkus1.Tierhinzufügen(new Tier("Fritzl", "Goldfisch"));


            //Aufrufen der Ausgabe Methode aus der zirkus Klasse
            zirkus1.Ausgabe();
            Console.ReadLine();


        }
    }
}
