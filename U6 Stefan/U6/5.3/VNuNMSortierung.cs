using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3
{
    public class VNuNMSortierung : IComparer<Adressdaten>          //Durch das Anlegen einer neuen Klasse welche von der ICompare KLasse erbt, kann das Interface bearbeitet werden
    {
        public int Compare(Adressdaten x, Adressdaten y)        //Hier wird immer ein Attribut der Klasse Adressdaten mit einem Anderen verglichen
        {
            if (x.Vorname == y.Vorname)
            {
                return x.Nachname.CompareTo(y.Nachname);        //In der if- Abfrage werden die Nachnamen verglichen
            }
            return x.Vorname.CompareTo(y.Vorname);          //Es wird immer erst der Vorname verglichen sollte dieser gleich sein wird die if Abfrage true
        }
    }
}
