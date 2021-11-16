using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Cli
{
    internal class Transporter : Vehicle
    {
        //MSBuild erstellt bei Auto-Properties automatisch im Hintergrund Getter-Methode
        //z.B. internal int get_LoadVolume()
        //wenn diese Methode nicht überschrieben wird, wird auch privates Feld angelegt, das den Wert speichert
        internal int LoadVolume { get; }

        //Ctor ruft mit : base(...) den Konstruktor der Basisklasse auf
        internal Transporter(string name, int power, int range, int loadVolume) : base(name, power, range) =>
            LoadVolume = loadVolume;

        //ToString-Methode von Object-Basisklasse überschrieben
        //wird automatisch aufgerufen, wenn man z.B. Console.Write() ein Object übergibt
        public override string ToString() =>
            //$-Prefix vor string (interpolated string) um in {} Expressions verwenden zu können, außerdem Performancevorteil ggü. Konkatenieren mit +
            $"Kleintransporter {Name} mit {Power} kW hat {Range} km Reichweite";

        internal override double CalcConsumption() =>   //override von abstrakter Methode aus Basisklasse
            10 * Math.Exp(LoadVolume / 10.0);
    }
}
