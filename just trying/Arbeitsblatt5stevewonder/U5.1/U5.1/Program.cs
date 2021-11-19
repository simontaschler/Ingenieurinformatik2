using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U5._1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Zirkusobjekt erstellen durch Aufrufen des Konstruktors
            var zirkus = new Zirkus("HalliGalli", 5, new TierTrainer("Klaus Müller"));

            //Tier Objekte mittels Konstruktor erstellen und direkt in das zirkus Objekt hinzufügen
            zirkus.AddTier(new Tier("Klaus", "Pferd"));
            zirkus.AddTier(new Tier("Herbert", "Maus"));
            zirkus.AddTier(new Tier("Herbert", "Eintagsfliege"));
            zirkus.AddTier(new Tier("Samy", "Hund"));
            zirkus.AddTier(new Tier("Günther", "Regenbogenforelle"));
            zirkus.AddTier(new Tier("Fritzl", "Goldfisch"));

            //Aufrufen der Ausgabe Methode aus der zirkus Klasse
            zirkus.Ausgabe();
            Console.ReadLine();
        }
    }
}
