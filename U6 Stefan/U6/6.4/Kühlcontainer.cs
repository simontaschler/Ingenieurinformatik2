using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4
{
    class KuehlContainer : Container        //Die Klasse Kühlcontainer erbt von der Klasse Container
    {
        public string Type;             //zusätzliches Attribut type

        public KuehlContainer(string Ware, double weight, string Type) : base(Ware, weight) => this.Type = Type;    //Konstruktor mit bekanntem Gewicht
        public KuehlContainer(string Ware, string Type) : base(Ware, 1) => this.Type = Type;                     //Konstruktor ohne bekanntem Gewicht --> Standardgewicht von 1000kg wird angenommen (1t)

        public override double getTemperature() => Type == "Tiefkuehlprodukte" ? -20 : 5;       //Wenn der Type "Tiefkühlprodukte" ist, dann ist die Temperatur auf -20Grad zu setzen, sonnst 5Grad
        public override string ToString() => $"{base.ToString()}, Type: {Type}";            //In der Tostring Methode wird nun zusätzlich noch der Type angegeben
    }
}
