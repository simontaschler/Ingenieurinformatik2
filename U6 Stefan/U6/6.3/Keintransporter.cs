using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3
{
    class Keintransporter : Fahrzeug
    {
        private int ladevolumen;
        public override double calcVerbrauch()
        {
            return (10 * Math.Exp(ladevolumen / 10));
        }
        public Keintransporter(string name,int leistung, int reichweite, int ladevolumen)
        {
            this.name = name;
            this.leistung = leistung;
            this.reichweite = reichweite;
            this.ladevolumen = ladevolumen;
        }
        public override string ToString()
        {
            return $"Das Fahrzeug Kleintransporter: {name} mit der Leistung {leistung} kW hat eine Reichweite von {reichweite} km!";
        }

    }
}
