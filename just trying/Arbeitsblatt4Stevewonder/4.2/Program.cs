using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[,] loesung = EinlesenDerLoesung();
            Console.WriteLine(loesung[1, 1]);
            Console.ReadLine();

        }
        static int[,] EinlesenDerLoesung()
        {
            int[,] loesungSudoku = new int[6, 6];
            int[] inputLoesung = { 1, 6, 4, 5, 3, 2, 5, 2, 3, 6, 1, 4, 4, 1, 2, 3, 6, 5, 3, 5, 6, 2, 4, 1, 6, 4, 5, 1, 2, 3, 2, 3, 1, 4, 5, 6 };
            string[,] arbeitsSudoku = new string[6, 6];

            int i = 1;

            int row = 1;
            int collumn = 1;


            //Schleife zum Einlesen des Loesungssudoku
            while (i <= 36)
            {

                if (i % 6 == 0)
                {
                    loesungSudoku[row - 1, collumn - 1] = inputLoesung[i - 1];
                    row++;
                    collumn = 1;
                    i++;
                }
                else
                {
                    loesungSudoku[row - 1, collumn - 1] = inputLoesung[i - 1];
                    collumn++;
                    i++;
                }

            }
            return loesungSudoku;
        }

            
    }

}
