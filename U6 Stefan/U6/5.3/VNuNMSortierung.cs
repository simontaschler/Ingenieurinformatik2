using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3
{
    class VNuNMSortierung : IComparer<Adressdaten>
    {
        public int Compare(Adressdaten x, Adressdaten y)
        {
            if (x.Vorname == y.Vorname)
            {
                return x.Nachname.CompareTo(y.Nachname);
            }
            return x.Vorname.CompareTo(y.Vorname);
        }
    }
}
