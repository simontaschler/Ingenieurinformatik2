using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Container C1 = new Container("Shampoo", 100);
            Container C2 = new Container("Fruechte", 400);
            Container C3 = new Container("Kondome", 1000);
            Container C4 = new Container("koks", 980);

            Console.WriteLine(C1 + "\n" + C2);
            Console.Read();
        }


    }
}
