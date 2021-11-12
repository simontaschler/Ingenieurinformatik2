using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bikes.Cli
{
    internal class EBike : Bike
    {
        //MSBuild erstellt bei Auto-Properties automatisch im Hintergrund Getter- und Setter-Methoden
        //z.B. internal int get_BatteryCapacity() bzw. private void set_BatteryCapacity(int value)
        //wenn diese Methoden nicht überschrieben werden, wird auch privates Feld angelegt, das den Wert speichert
        internal int BatteryCapacity { get; private set; }

        //Ctor ruft mit : base(...) den Konstruktor der Basisklasse auf
        public EBike(int gears, FrameSize frame, int batteryCapacity) : base(gears, frame) => 
            BatteryCapacity = batteryCapacity;

        internal override void Drive(int km) //Virtual Methode aus Basisklasse überschrieben
        {
            Wear += km / 500 - BatteryCapacity / 1000; //EBike hat geringeren Verschleiß solange Akku nicht leer ist
            if (BatteryCapacity > 0)
            {
                //Conditional Expression (kurzschreibweise für ifs): <logische Bedingung> ? <Wert wenn true> : <Wert wenn false>
                BatteryCapacity -= BatteryCapacity - BatteryCapacity * km / 100 < 0 
                    ? BatteryCapacity * km / 100
                    : BatteryCapacity;
            }
        }

        //ToString-Methode von Object-Basisklasse überschrieben
        //wird automatisch aufgerufen, wenn man z.B. Console.Write() ein Object übergibt
        public override string ToString() =>
            $"E-Bike, Verschleiß: {Wear}";
    }
}
