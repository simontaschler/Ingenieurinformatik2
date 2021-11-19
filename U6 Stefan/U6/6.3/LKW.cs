using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3
{
    class LKW : Fahrzeug        //LKW erbt von Fahrzeug
    {
        private int zuladung;       //zusätzliches Attribut zuladung
        public override double calcVerbrauch()      //überschreiben der  calcVerbrauch Methode 
        {
            return (0.7*zuladung+14);
        }
        public LKW(string name, int leistung, int reichweite, int zuladung)     //Kosntruktor der Klasse LKW
        {
            this.name = name;
            this.leistung = leistung;
            this.reichweite = reichweite;
            this.zuladung = zuladung;
        }
        public override string ToString() //Überschreiben der Standard ToString Methode um einen gewünschten Rückgabewert des Objekts festzulegen
        {
            return $"Das Fahrzeug LKW: {name} mit der Leistung {leistung} kW hat eine Reichweite von {reichweite} km!\nDer Verbrauch beläuft sich auf: {this.calcVerbrauch()}";
        }
    }
}
