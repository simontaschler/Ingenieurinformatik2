using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U6
{
    class Handy_Comparer : IComparer<Handy>     //Festlegen einer Klasse Handy comparer zum einstellen gewüsnchter Vergleichspparameter
    {
        public int Compare(Handy x, Handy y)        //Im comparer können zwei Elemente x und y verglichen werden
        {
            if (x.Price == y.Price)                 // Wenn der gleiche preis vorliegt soll weiters der Name des Modells verlgichen werden
            {
                return x.Name.CompareTo(y.Name);        //Der Return Wert ist entweder größer als 0, 0 oder kleiner als 0 
                                                        //Ist der Wert >0 ????
            }
            return x.Price.CompareTo(y.Price);          //Else wird ganz normal nach Preis sortiert (Preise miteinander Verglichen
        }
    }
}
