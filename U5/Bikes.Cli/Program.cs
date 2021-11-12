using System;

namespace Bikes.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var bikes = new Bike[] //Array mit Rädern anlegen
            { 
                new RoadBike(14, FrameSize.M, 2),   //FrameSize siehe Bike.cs
                new EBike(7, FrameSize.S, 200),
                new Bike(21, FrameSize.L)
            };

            for (var i = 0; i < bikes.Length; i++) 
            {
                Console.WriteLine($"{bikes[i]} tritt Fahrt an.");

                for (var km = 0; km < 2000; km += 10) //Schleife zum Simulieren der 2000km Fahrt
                {
                    bikes[i].Drive(10);

                    if (bikes[i].Wear >= .95)
                    {
                        bikes[i] = null;    //Rad wird "verschrottet", Feld wird in Array null gesetzt damit Objekt von Garbage Collection freigegeben wird
                        break;
                    }
                    else if (bikes[i].Wear >= .8)
                    {
                        Console.WriteLine("Warnung: Verschleiß in kritischem Bereich!"); //Warnung, wenn Verschleiß >= 0.8
                    }
                }

                if (bikes[i] != null)
                    Console.WriteLine($"{bikes[i]} tritt Fahrt an.");
                else
                    Console.WriteLine("Das Rad hat die Fahrt nicht überstanden und wurde verschrottet");
            }
        }
    }
}
