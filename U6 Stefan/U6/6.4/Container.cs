using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4
{
    class Container
    {
        private int ID;
        private static int StaticID = 1;
        public string Ware;
        private double weight;     


        public Container (string Ware, double weight )
        {
            this.ID = StaticID;
            this.Ware = Ware;
            this.weight = weight;
            StaticID++;            
        }
        public virtual double getTemperature() => 20;
        public double getWeight() => this.weight;
        public override string ToString() => $"ID: {ID}, Ware: {Ware}, Gewich: {weight}";






    }
}
