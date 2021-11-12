using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bikes.Cli
{
    //Enumeration Type
    //Datentyp definiert durch die Definition eines Satzes von Konstanten eines unterliegenden ganzzahligen Datentyps
    //Wird praktisch dazu verwendet, drei zulässige Größen für die Rahmengröße zu definieren
    internal enum FrameSize 
    { 
        S,
        M,
        L
    }

    internal class Bike
    {
        //MSBuild erstellt bei Auto-Properties automatisch im Hintergrund Getter- und Setter-Methoden
        //z.B. internal int get_Gears() bzw. internal void set_Gears(int value)
        //wenn diese Methoden nicht überschrieben werden, wird auch privates Feld angelegt, das den Wert speichert
        internal int Gears { get; set; }
        internal FrameSize Frame { get; set; }
        internal double Wear { get; set; }

        internal Bike(int gears, FrameSize frame) 
        {
            Gears = gears;
            Frame = frame;
            Wear = 0; //Fahrrad startet im Neuzustand
        }

        internal virtual void Drive(int km) => //Methode virtual damit sie von Derivaten überschrieben werden kann
            Wear += km / 500;

        //ToString-Methode von Object-Basisklasse überschrieben
        //wird automatisch aufgerufen, wenn man z.B. Console.Write() ein Object übergibt
        public override string ToString() => 
            $"Fahrrad, Verschleiß: {Wear}";
    }
}
