using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Cli
{
    internal class Car : Vehicle
    {
        //MSBuild erstellt bei Auto-Properties automatisch im Hintergrund Getter-Methode
        //z.B. internal int get_Seats()
        //wenn diese Methode nicht überschrieben wird, wird auch privates Feld angelegt, das den Wert speichert
        internal int Seats { get; }

        //Ctor ruft mit : base(...) den Konstruktor der Basisklasse auf
        internal Car(string name, int power, int range, int seats) : base(name, power, range) =>
            Seats = seats;

        //ToString-Methode von Object-Basisklasse überschrieben
        //wird automatisch aufgerufen, wenn man z.B. Console.Write() ein Object übergibt
        public override string ToString() =>
            //$-Prefix vor string (interpolated string) um in {} Expressions verwenden zu können, außerdem Performancevorteil ggü. Konkatenieren mit +
            $"PKW {Name} mit {Power} kW hat {Range} km Reichweite";

        internal override double CalcConsumption() =>   //override von abstrakter Methode aus Basisklasse
            5 + Seats / 1.5;
    }
}
