using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift.Cli
{
    internal class Skitow : Lift
    {
        internal int NumLanes { get; set; }

        //Ctor ruft mit : base(...) den Konstruktor der Basisklasse auf
        internal Skitow(int velocity, int length, int elements, int numLanes) : base(velocity, length, elements) =>
            NumLanes = numLanes;

        //override der abstrakten Methode aus Baseclass
        internal override double CalcFlowRate() =>
            //Conditional Expression (kurzschreibweise für ifs): <logische Bedingung> ? <Wert wenn true> : <Wert wenn false>
            Length != 0
                ? NumLanes * Velocity * Elements / Length
                : 0;

        //ToString-Methode von Object-Basisklasse überschrieben
        //wird automatisch aufgerufen, wenn man z.B. Console.Write() ein Object übergibts
        public override string ToString() =>
            //$-Prefix um in {} Expressions verwenden zu können, außerdem Performancevorteil ggü. Konkatenieren mit +
            $"Schlepplift {Number} mit Durchsatz von {CalcFlowRate()}";
    }
}
