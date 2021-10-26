using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = new int[5,5];

            for (var i = 0; i < 5; i++) 
            { 
                for (var j = 0; j < 5; j++) 
                {
                        matrix[i, j] = i == j
                            ? 1
                            : 0;
                }
            }

            Console.ReadLine();
        }
    }
}
