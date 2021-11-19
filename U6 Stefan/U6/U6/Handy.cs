using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U6
{
    class Handy : IComparable<Handy>
    {
        public string Name { get; set; }
        public double Price { get; set;}

        public Handy(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public override string ToString()
        {
            return Name + "\t" + Price + "€";
        }

        public int CompareTo(Handy other)
        {
            return Price.CompareTo(other.Price);
        }
    
    
    }
}
