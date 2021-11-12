using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift.Cli
{
    internal abstract class Lift
    {
        //Statisches Feld für nächste Liftnummer
        protected static int NextNumber = 1;

        //MSBuild erstellt bei Auto-Properties automatisch im Hintergrund Getter- und Setter-Methoden
        //z.B. internal int get_Length() bzw. internal void set_Length(int value)
        //wenn diese Methoden nicht überschrieben werden, wird auch privates Feld angelegt, das den Wert speichert
        internal int Number { get; }
        internal int Velocity { get; set; }
        internal int Length { get; set; }
        internal int Elements { get; set; }

        internal Lift(int velocity, int length, int elements)
        {
            Number = NextNumber;
            NextNumber++;
            Velocity = velocity;
            Length = length;
            Elements = elements;
        }

        internal abstract double CalcFlowRate(); //abtsrakte Methoden müssen von Derivaten implementiert müssen
        public abstract override string ToString();
    }
}