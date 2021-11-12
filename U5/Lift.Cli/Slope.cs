using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift.Cli
{
    internal class Slope
    {
        protected static int NextName = 1;

        internal string Name { get; }
        internal int Length { get; set; }
        internal Lift Lift { get; set; }

        internal Slope(int length, Lift lift, string name = null/*optionaler Parameter, kann übergeben, muss aber nicht, wenn nicht wird Wert nach = angenommen*/) 
        {
            Length = length;
            Lift = lift;
            //Wenn kein Name übergeben wurde wird mit statischem Index die Piste fortlaufend numeriert
            //Sonst wird übergebener Name gesetzts
            if (string.IsNullOrWhiteSpace(name))
            {
                Name = $"{NextName}";
                NextName++;
            }
            else 
            {
                Name = name;
            }
        }

        //ToString-Methode von Object-Basisklasse überschrieben
        //wird automatisch aufgerufen, wenn man z.B. Console.Write() ein Object übergibt
        public override string ToString() =>
            //$-Prefix um in {} Expressions verwenden zu können, außerdem Performancevorteil ggü. Konkatenieren mit +
            $"Piste {Name} mit Länge von {Length} wird durch Lift {Lift.Number} ergänzt";
    }
}
