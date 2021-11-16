using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Cli
{
    internal class Truck : Vehicle
    {
        //MSBuild erstellt bei Auto-Properties automatisch im Hintergrund Getter-Methode
        //z.B. internal int get_Load()
        //wenn diese Methode nicht überschrieben wird, wird auch privates Feld angelegt, das den Wert speichert
        internal int Load { get; }

        //Ctor ruft mit : base(...) den Konstruktor der Basisklasse auf
        internal Truck(string name, int power, int range, int load) : base(name, power, range) =>
            Load = load;

        //ToString-Methode von Object-Basisklasse überschrieben
        //wird automatisch aufgerufen, wenn man z.B. Console.Write() ein Object übergibt
        public override string ToString() =>
            //$-Prefix vor string (interpolated string) um in {} Expressions verwenden zu können, außerdem Performancevorteil ggü. Konkatenieren mit +
            $"LKW {Name} mit {Power} kW hat {Range} km Reichweite, Verbrauch: {CalcConsumption()} l/100km";

        internal override double CalcConsumption() =>   //override von abstrakter Methode aus Basisklasse
            .7 * Load + 14;
    }
}
