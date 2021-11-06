using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Cli
{
    internal class Order
    {
        private static int nextID = 1;

        private readonly string Name;
        private readonly float Price;
        private readonly int ID;
    
        internal Order(string name, float price = 0F /*optionaler Parameter, wird wenn nicht übergeben mit gegebenem Wert initialisiert*/) 
        {
            Name = name;
            Price = price;
            ID = nextID;
            nextID++;
        }

        internal Order(float price = 0F) 
        {
            Name = "???";
            Price = price;
            ID = nextID;
            nextID++;
        }

        public override string ToString() =>
            $"{ID}: {Name}, {Price:C2}";
    }
}
