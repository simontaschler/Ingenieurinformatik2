using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3
{
    class PKW : Fahrzeug        //PKW erbt von Fahrzeug
    {
        private  int sitzplaetze;       //zusätzlich Sitzplaetze
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
        public override string ToString()       //Überschreiben der Standard ToString Methode um einen gewünschten Rückgabewert des Objekts festzulegen
        {
            return $"Das Fahrzeug PKW: {name} mit der Leistung {leistung} kW hat eine Reichweite von {reichweite} km!";
        }
    }
}
