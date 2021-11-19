using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3
{
    class PKW : Fahrzeug
    {
        private  int sitzplaetze;
        public override double calcVerbrauch()
        {
            return (5 + sitzplaetze / 1.5);
        }
        public PKW(string name, int leistung, int reichweite, int sitzplaetze)
        {
            this.name = name;
            this.leistung = leistung;
            this.reichweite = reichweite;
            this.sitzplaetze = sitzplaetze;
        }
        public override string ToString()
        {
            return $"Das Fahrzeug PKW: {name} mit der Leistung {leistung} kW hat eine Reichweite von {reichweite} km!";
        }
    }
}
