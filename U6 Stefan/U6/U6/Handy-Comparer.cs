using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U6
{
    class Handy_Comparer : IComparer<Handy>
    {
        public int Compare(Handy x, Handy y)
        {
            if (x.Price == y.Price)
            {
                return x.Name.CompareTo(y.Name);
            }
            return x.Price.CompareTo(y.Price);
        }
    }
}
