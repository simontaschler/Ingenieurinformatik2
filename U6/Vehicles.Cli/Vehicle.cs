using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Cli
{
    internal abstract class Vehicle //abstrakte Klasse => keine Objekte können erzeugt werden
    {
        //MSBuild erstellt bei Auto-Properties automatisch im Hintergrund Getter-Methode
        //z.B. internal string get_Name()
        //wenn diese Methode nicht überschrieben wird, wird auch privates Feld angelegt, das den Wert speichert
        internal string Name { get; }
        internal int Power { get; }
        internal int Range { get; }

        protected Vehicle(string name, int power, int range)
        {
            Name = name;
            Power = power;
            Range = range;
        }

        internal abstract double CalcConsumption(); //abstrakte Methode: muss von Derivaten implementiert werden
        public abstract override string ToString(); //abstrakte override Methode: Derivate müssen auch eigenes ToString implementieren
    }
}
