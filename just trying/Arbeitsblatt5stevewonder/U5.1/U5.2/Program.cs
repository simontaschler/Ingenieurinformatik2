using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 89452;      //Festlegen des ersten Inputparameters
            int b = 458;        //Festlegen des zweiten Inputparameters

            Console.WriteLine("Iterative Methode:\nDer Größte gemeinsame Teiler ist: " + Methoden.Rechenweg1(a, b));        //Aufrufen der ersten Methode (iterative Methode) und Ausgabe des Return Wertes
            Console.WriteLine("\n-------------------------------------\n");                                         //Abstand in der Konsolenausgabe
            Console.WriteLine("Rekursive Methode:\nDer Größte gemeinsame Teiler ist: " + Methoden.Rechenweg2(a, b));        //Aufrufen der zweiten Methode (rekursive Methode) und Ausgabe des Return Wertes
            Console.ReadLine();

        }
    }
}
