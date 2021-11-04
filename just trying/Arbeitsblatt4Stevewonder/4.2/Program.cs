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
            int[,] spielvorgabe = EinlesnDerSpielvorlage();


            string Spielstand= string.Join("|", spielvorgabe);
            Console.Write(Spielstand);
            Console.ReadLine();

        }
        static int[,] EinlesenDerLoesung()
        {
            int[,] loesungSudoku = new int[6, 6];
            int[] inputLoesung = { 1, 6, 4, 5, 3, 2, 5, 2, 3, 6, 1, 4, 4, 1, 2, 3, 6, 5, 3, 5, 6, 2, 4, 1, 6, 4, 5, 1, 2, 3, 2, 3, 1, 4, 5, 6 };

            int i = 1;

            int rowcount = 0;
            int collumncount = 0;


            //Schleife zum Einlesen des Loesungssudoku
            while (i <= 36)
            {

                if (i % 6 == 0)
                {
                    loesungSudoku[rowcount, collumncount] = inputLoesung[i - 1];
                    rowcount++;
                    collumncount = 0;
                    i++;
                }
                else
                {
                    loesungSudoku[rowcount, collumncount] = inputLoesung[i - 1];
                    collumncount++;
                    i++;
                }

            }
            return loesungSudoku;
        }

        static int[,] EinlesnDerSpielvorlage()
        {
            int[,] spielvorgabeSudoku = new int[6, 6];
            int[] inputSpielvorgabe = {1, 6, 0, 5, 0, 2, 5, 0, 3, 0, 1, 4, 0, 1, 2, 0, 6, 0, 3, 0, 6, 2, 0, 1, 6, 0, 0, 0, 2, 0, 2, 3, 1, 4, 0, 6};
           
            int i = 1;

            int row = 0;
            int collumn = 0;


            //Schleife zum Einlesen der Spielvorgabe
            while (i <= 36)
            {

                if (i % 6 == 0)
                {
                    spielvorgabeSudoku[row, collumn] = inputSpielvorgabe[i - 1];
                    row++;
                    collumn = 0;
                    i++;
                }
                else
                {
                    spielvorgabeSudoku[row, collumn] = inputSpielvorgabe[i - 1];
                    collumn++;
                    i++;
                }

            }
            return spielvorgabeSudoku;

        }
    }

}
