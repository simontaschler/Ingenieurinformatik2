using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._7
{
    class EBike : Fahrrad
    {
        int Akkukapazität;

        public EBike(int Schaltstufen, int Rahmengröße, int Reperaturwert, int Akkukapazität) : base(Schaltstufen, Rahmengröße, Reperaturwert)
        {
            this.Akkukapazität = Akkukapazität;
        }

        public override double Verschleissrechner(double x)
        {
            return (x / 600);
        }
    }
}
