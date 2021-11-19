using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2._2
{
    class Program
    {
        static void Main(string[] args)
        {

        //Berechnung mit Eingabewerten in Datentyp double:
            double Hypothenuse = 10;
            double Ankathete = 5;

            double CosAlpha = Ankathete / Hypothenuse;
            double alpha = Math.Acos(CosAlpha);

        //Berechnung mit Eingabewerten im Datentyp integer:
            int Hypothenuseint = 10;
            int Ankatheteint = 5;

            var CosAlphaInt = Ankatheteint / Hypothenuseint;
            var Alphaint = Math.Acos(CosAlphaInt);



            Console.WriteLine("Die Berechnung mit den Eingabewerten im Datentyp double ergibt:\nCosinus Alpha: " + CosAlpha + "\nAlpha: " + alpha + "rad\n" );
            Console.WriteLine("Die Berechnung mit den Eingabewerten im Datentyp integer ergibt:\nCosinus Alpha: " + CosAlphaInt + "\nAlpha: " + Alphaint + "rad");
            Console.ReadLine();
            
            //Durch die Berechnung im Dateityp integer ergibt sich ein anderes Ergebnis, da die Variable CosAlphaint statt dem richtigen Wert (0,5) nun den Integer 0 ausgibt. Die weiteren Berechnungen sind daher falsch.

        }
    }
}
