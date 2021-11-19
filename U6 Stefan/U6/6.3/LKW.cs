using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3
{
    class LKW : Fahrzeug
    {
        private int zuladung;
        public override double calcVerbrauch()
        {
            return (0.7*zuladung+14);
        }
        public LKW(string name, int leistung, int reichweite, int zuladung)
        {
            this.name = name;
            this.leistung = leistung;
            this.reichweite = reichweite;
            this.zuladung = zuladung;
        }
        public override string ToString()
        {
            return $"Das Fahrzeug LKW: {name} mit der Leistung {leistung} kW hat eine Reichweite von {reichweite} km!\nDer Verbrauch beläuft sich auf: {this.calcVerbrauch()}";
        }
    }
}
