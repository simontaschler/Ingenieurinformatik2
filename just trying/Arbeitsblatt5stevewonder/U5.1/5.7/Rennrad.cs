using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._7
{
    class Rennrad : Fahrrad
    {
        int Luftwiederstandsnote;

        public Rennrad(int Schaltstufen, int Rahemngröße, int Reperaturwert, int Luftwiederstandsnote) : base(Schaltstufen, Rahemngröße, Reperaturwert)
        {
            this.Luftwiederstandsnote = Luftwiederstandsnote;
        }

        public override double Verschleissrechner(double x)
        {
            return (x / 500 * Luftwiederstandsnote / 5);
        }
        

    
    }
}
