using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._7
{
    class Fahrrad
    {
        int Schaltstufen;
        int Rahmengröße;
        int Reperaturwert;

        public Fahrrad(int Schaltstufen, int Rahmengröße, int Reperaturwert)
        {
            this.Schaltstufen = Schaltstufen;
            this.Rahmengröße = Rahmengröße;
            this.Reperaturwert = Reperaturwert;
        }
            public virtual double Verschleissrechner(double x)
            {
                return (x / 500);
            }
        
    }
}
