using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2._3
{
    class Program
    {
        static void Main(string[] args)
        {
        //Erstellen einer Liste in der die ungeraden Zahlen aufsteigend geordnet sind, und erstellen einer Laufvariablen für die ungeraden Zahlen
            var Liste = new List<int>();
            var ungeradeZahlen = 1;

        //Die for Schleife läuft in Ihrer Laufvariablen i von 0-10. In jedem Schritt der Schleife wird die variable der ungeraden Zahlen um 2 erhöht und der Liste hinzugefügt.
            for (int i = 0; i <= 10; ungeradeZahlen = ungeradeZahlen + 2, i = i + 1)
                Liste.Add(ungeradeZahlen);

        //Um die Liste in der Konsole ausgeben zu können, wird sie in einen String konvertiert. Hierbei wird der String " " als Seperator verwendet (Leerzeichen zwischen den Elementen)
            string output1 = string.Join(" " , Liste);
         
        //Umkehren der Liste in abfallende Reihenfolge
            Liste.Reverse();

        //Konvertieren der abfallenden Liste in einen String
            string output2 = string.Join(" " , Liste);

        //Ausgabe über die Konsole
            Console.WriteLine(output1 + " " + output2);
            Console.ReadLine();


        }
    }
}
