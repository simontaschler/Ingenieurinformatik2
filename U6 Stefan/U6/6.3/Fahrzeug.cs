using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3
{
    abstract class Fahrzeug         //Anlegen einer abstrakten Klasse Fahrzeug
    {                               //Die Klasse enthaltet folgende Attribute: name, leistung, reichweite
        public string name { get; set; }
        public int leistung { get; set; }
        public int reichweite { get; set; }

        public abstract double calcVerbrauch();     //Festlegen einer abstrakten Methode (muss überschrieben werden)

    }
}
