using System;
using System.Collections.Generic;

namespace Lift.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var lifts = new List<Lift>      //Liste von Liften anlegen
            { 
                new ChairLift(100, 1500, 40, 4),
                new ChairLift(90, 1200, 30, 2),
                new Skitow(50, 600, 30, 2)
            };

            var slopes = new List<Slope>    //Liste von Pisten anlegen
            { 
                new Slope(2500, lifts[0]),
                new Slope(2200, lifts[0]),
                new Slope(1700, lifts[1]),
                new Slope(1600, lifts[1]),
                new Slope(800, lifts[2])
            };

            Console.WriteLine(string.Join(Environment.NewLine, lifts));     //string.Join fügt Collection zu einem string zusammen
            Console.WriteLine();                                            //Elemente werden mit angegebenem Separator (1. Parameter) unterteilt
            Console.WriteLine(string.Join(Environment.NewLine, slopes));    //ruft für jedes einzelnen Element der Collection ToString() auf
        }
    }
}
