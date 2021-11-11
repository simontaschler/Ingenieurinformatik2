using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U5._1
{
    class Tier
    {
        public string rasseTier { get; set; }
        public string nameTier { get; set; }


        //Konstruktor zum erstellen eines Tier Objektes
        public Tier(string nameTier, string rasseTier)
        {
            this.nameTier = nameTier;
            this.rasseTier = rasseTier;

        }

        //Methode zur Ausgabe der Tiernamen und Rassen
        public void Tierausgabe()
        {
            Console.WriteLine("                 " + nameTier + " " + rasseTier);
        }

    
    }
}
