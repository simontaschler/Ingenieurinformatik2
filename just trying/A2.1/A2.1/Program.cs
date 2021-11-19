using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2._1
{
    class Program
    {
        static void Main(string[] args)
        {
        //Einlesen der Punktestände über die Konsole
            Console.WriteLine("Geben Sie den Punktestand des ersten Spielers ein!");
            string inputPlayer1 = Console.ReadLine();

            
            Console.WriteLine("Geben Sie den Punktestand des zweiten Spielers ein!");
            string inputPlayer2 = Console.ReadLine();


            Console.WriteLine("Geben Sie den Punktestand des dritten Spielers ein!");
            string inputPlayer3 = Console.ReadLine();



        //Konvertieren der eingelesenen Werten als string in den Datentyp double um damit weiterrechnen zu können
            double PunkteSpieler1 = Double.Parse(inputPlayer1);
            double PunkteSpieler2 = Double.Parse(inputPlayer2);
            double PunkteSpieler3 = Double.Parse(inputPlayer3);


        //Berechnen der Summe
            double sum = PunkteSpieler1 + PunkteSpieler2 + PunkteSpieler3;
            

        //Ausgabe der Ergebnisse über die Konsole:
            Console.WriteLine("Der Punktestand der Spieler lautet: \nSpieler 1: " + inputPlayer1 + "\nSpieler 2: " + inputPlayer2 + "\nSpeiler 3: " + inputPlayer3 + "\n*************************\nDie Summe der Bonuspunkte beträgt: " + sum);
            Console.ReadLine();
        }
    }
}
