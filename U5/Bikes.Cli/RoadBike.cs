using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bikes.Cli
{
    internal class RoadBike : Bike
    {
        //MSBuild erstellt bei Auto-Properties automatisch im Hintergrund Getter- und Setter-Methoden
        //z.B. internal int get_DragFactor() bzw. private void set_DragFactor(int value)
        //wenn diese Methoden nicht überschrieben werden, wird auch privates Feld angelegt, das den Wert speichert
        internal int DragFactor { get; private set; }

        //Ctor ruft mit : base(...) den Konstruktor der Basisklasse auf
        public RoadBike(int gears, FrameSize frame, int dragFactor) : base(gears, frame) =>
            DragFactor = dragFactor;

        internal override void Drive(int km) => //Virtual Methode aus Basisklasse überschrieben
            Wear += km / 500 * (DragFactor / 5);

        //ToString-Methode von Object-Basisklasse überschrieben
        //wird automatisch aufgerufen, wenn man z.B. Console.Write() ein Object übergibt
        public override string ToString() =>
            $"Rennrad, Verschleiß: {Wear}";
    }
}
