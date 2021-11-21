using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4
{
    class Tankcontainer : Container
    {
        private double gasMass;
        private double preassure;
        private double R;
        private double volume;
        public Tankcontainer(string Ware, double weight, double gasMass, double volume, double preassure) : base(Ware, weight)
        {
            this.gasMass = gasMass;
            this.preassure = preassure;
            this.volume = volume;
            switch (Ware)
            {
                case "Luft":
                    this.R = 287.05;
                    break;
                case "Helium":
                    this.R = 2077;
                    break;
                default:
                    Console.WriteLine("ERROR 42069: Unbekanntes Medium! Gaskonstante von Luft angenommen (287,05).");
                    this.R = 287.05;
                    break;
            }
        }
            public override double getTemperature() => (preassure * volume) / (gasMass * R);          
        
            
        
    }     
}
        
    
