using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4
{
    class KuehlContainer : Container
    {
        public string Type;

        public KuehlContainer(string Ware, double weight, string Type) : base(Ware, weight) => this.Type = Type;
        public KuehlContainer(string Ware, string Type) : base(Ware, 1000) => this.Type = Type;

        public override double getTemperature() => Type == "Tiefkuehlprodukte" ? -20 : 5;
        public override string ToString() => $"{base.ToString()}, Type: {Type}";          
    }
}
