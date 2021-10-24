using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinks.Cli
{
    internal class Drink
    {
        private static int nextID = 1;

        internal int ID { get; }
        internal string Name { get; set; }
        internal float Alcohol { get; set; }
        internal bool Mixable { get; set; }

        public Drink()
        {
            ID = nextID;
            nextID++;
        }

        public override string ToString() =>
            new StringBuilder($"  {ID}".PadRight(12))
            .Append(Name.PadRight(12))
            .Append($"{Alcohol}".PadRight(12))
            .Append($"{Mixable}".PadRight(12))
            .ToString();
    }
}
