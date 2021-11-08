using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinks.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var drinks = new List<Drink>
            {
                new Drink
                {
                    Name = "Kaffee",
                    Alcohol = 0,
                    Mixable = false
                },
                new Drink
                {
                    Name = "Eistee",
                    Alcohol = 0,
                    Mixable = false
                },
                new Drink
                {
                    Name = "Bier",
                    Alcohol = 5.2F,
                    Mixable = true
                },
                new Drink
                {
                    Name = "Weißwein",
                    Alcohol = 12.5F,
                    Mixable = true
                },
                new Drink
                {
                    Name = "Milch",
                    Alcohol = 0,
                    Mixable = true
                }
            };

            Console.WriteLine("Lagernr.   Name     Alkoholgehalt  Mit Cola mischbar?");
            Console.WriteLine(string.Join(Environment.NewLine, drinks));    //string.Join erstellt string aus allen Elemente der Collection mit angegeben Seperator (NewLine)
                                                                            //string.Join erhält Liste an Objekten, ruft deshalb für jedes Objekt die ToString-Methode aus Basisklasse Object auf
            Console.ReadLine();
        }
    }
}
