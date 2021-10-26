using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var battery = new Battery();
            var car = new Car("Tesla", 0.2, battery);
            car.Drive(40);
            car.Drive(58);
            car.Drive(30);
            car.Drive(400);

            Console.ReadLine();
        }
    }
}
