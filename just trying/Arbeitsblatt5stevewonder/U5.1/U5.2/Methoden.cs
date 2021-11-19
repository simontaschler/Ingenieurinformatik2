using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U5._2
{
    class Methoden
    {
        public static int Rechenweg1(int inputA, int inputB)        //Iterative Methode zur Berechnung des kleinsten gemeinsamen Teilers
        {
            int a = inputA;
            int b = inputB;
            int i = 1;
            int GgT = 1;
            int größereZahl;
             
             //If Abfrage um die größere der beiden Input Zahlen festzulegen   
            if(a>=b)
            {
                größereZahl = a;    //Wenn a größer ist als b, so ist a die größere Zahl, wenn beide Zahlen gleich groß sind ist es egal welche Zahl weiter gegeben wird
            }
            else
            {
                größereZahl = b;    //Sonnst wird b als größereZahl weitergegeben
            }

            //Die while Schleife läuft mit allen int. Zahlen von 0 bis zur größeren der beiden Inputparametern durch
            while (i <= größereZahl)
            {
                if (a % i == 0 && b % i == 0) //Wenn beide Zahlen a und b restlos durch einen Wert i teilbar sind, so ist diese Zahl ein gemeinsamer Teiler
                {
                    GgT = i;                    //Der aktuelle Teiler wird in die Variable GgT gespeiechert. Ist ein späterer (--> größerer GgT) gefunden, so wird der alte überschrieben
                    i++;                        //i wird bei jedem Durchlauf in beiden if cases um eins erhöht
                }
                else
                {
                    i++;
                }

            }
            return GgT;                         //Anschließend wird der entgülltige GgT als return Wert der Methode festgelegt.
        }

        public static int Rechenweg2(int inputA, int inputB)
        {
            int a = inputA;
            int b = inputB;
            if (b == 0)
                return a;                           //Falls b = 0 ist, ist a der gemeinsame größte Teiler
            else
            {
                return Rechenweg2(b, a % b);        //Die Methode wird nocheinmal von vorne aufgerufen, jedoch verändern sich die Parameter
            }
           
        }   

    }
}
//Rekursive Methoden sind Methoden welche sich zur Berechnung eines Wertes selber aufruft
//Sie bilden daher eine alternative zu herkömmlichen Schleifen