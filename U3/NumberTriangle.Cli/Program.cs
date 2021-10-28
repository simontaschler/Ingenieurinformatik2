using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTriangle.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentNumber = 0;
            var numCollection = new List<int>();

            for (var i = 1; i <= 25; i++)
            {
                currentNumber += i;
                numCollection.Add(currentNumber);
            }

            Console.WriteLine(string.Join(", ", numCollection.Where(q => q % 5 == 0))); //where --> ist ein Filter der nur q's (als Collection) mit logischer Verknüpfung= true ausgibt
            Console.ReadLine();
        }
    }
}
