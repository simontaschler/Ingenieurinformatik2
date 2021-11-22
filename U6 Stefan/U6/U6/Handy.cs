using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U6
{
    class Handy : IComparable<Handy>            //Festlegen einer neuen Klasse Handy inkl. Einbidung des Interfaces Comparable
    {
        public string Name { get; set; }        //Attribute: Name als string sowie Price als double
        public double Price { get; set;}

        public Handy(string name, double price)     //Festlegen eines Konstruktors um Objekte anzulegen
        {
            this.Name = name;
            this.Price = price;
        }

        public override string ToString()           //Um das Modell später in einem gewünschten Format auszugeben, wird die standardmäßige ToString Methode überschrieben
        {
            return Name + "\t" + Price + "€";       
        }

        public int CompareTo(Handy other)           //Das IComparable vergleicht den Wert eines Attributes mit einem anderen
        {
            return Price.CompareTo(other.Price); //in diesem Fall der Preis
        }
    
    
    }
}
