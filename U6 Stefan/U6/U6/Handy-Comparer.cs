using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U6
{
    class Handy_Comparer : IComparer<Handy>     //Festlegen einer Klasse Handy_comparer zum einstellen gewünschter Vergleichsparameter
    {
        public int Compare(Handy x, Handy y)        //Im comparer können zwei Elemente x und y verglichen werden
        {
            if (x.Price == y.Price)                 // Wenn der gleiche Preis vorliegt soll weiters der Name des Modells verglichen werden
            {
                return x.Name.CompareTo(y.Name);       
            }
            return x.Price.CompareTo(y.Price);          //Else wird nach Preis sortiert
        }
    }
}
