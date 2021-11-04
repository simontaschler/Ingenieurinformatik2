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

            
            //Ausgabe des aktuellen Spielstandes über die Konsole
            int i = 0;
            int[] Zeile1 = new int[6];
            int[] Zeile2 = new int[6];
            int[] Zeile3 = new int[6];
            int[] Zeile4 = new int[6];
            int[] Zeile5 = new int[6];
            int[] Zeile6 = new int[6];
            int[] inputLoesung = { 1, 6, 4, 5, 3, 2, 5, 2, 3, 6, 1, 4, 4, 1, 2, 3, 6, 5, 3, 5, 6, 2, 4, 1, 6, 4, 5, 1, 2, 3, 2, 3, 1, 4, 5, 6 };
            int[] spielstandvergleich = new int[35];
            spielstandvergleich = (Zeile1.Concat(Zeile2).Concat(Zeile3).Concat(Zeile4).Concat(Zeile5).Concat(Zeile6)).ToArray();
            
            while (!inputLoesung.SequenceEqual(spielstandvergleich)) //Vergleich funktioniert nicht?? deshalb if break....
            {
                do
                {
                    Zeile1[i] = spielvorgabe[0, i];
                    i++;
                }
                while (i <= 5); //output Zeile 1
                string outputZeile1 = string.Join(" ", Zeile1);
                Console.WriteLine(outputZeile1);
                i = 0;

                do
                {
                    Zeile2[i] = spielvorgabe[1, i];
                    i++;
                }
                while (i <= 5); //output Zeile 2
                string outputZeile2 = string.Join(" ", Zeile2);
                Console.WriteLine(outputZeile2);
                i = 0;

                do
                {
                    Zeile3[i] = spielvorgabe[2, i];
                    i++;
                }
                while (i <= 5); //output Zeile 3
                string outputZeile3 = string.Join(" ", Zeile3);
                Console.WriteLine(outputZeile3);
                i = 0;

                do
                {
                    Zeile4[i] = spielvorgabe[3, i];
                    i++;
                }
                while (i <= 5); //output Zeile 4
                string outputZeile4 = string.Join(" ", Zeile4);
                Console.WriteLine(outputZeile4);
                i = 0;

                do
                {
                    Zeile5[i] = spielvorgabe[4, i];
                    i++;
                }
                while (i <= 5); //output Zeile 5
                string outputZeile5 = string.Join(" ", Zeile5);
                Console.WriteLine(outputZeile5);
                i = 0;

                do
                {
                    Zeile6[i] = spielvorgabe[5, i];
                    i++;
                }
                while (i <= 5); //output Zeile 6
                string outputZeile6 = string.Join(" ", Zeile6);
                Console.WriteLine(outputZeile6);
                i = 0;
                
                spielstandvergleich = (Zeile1.Concat(Zeile2).Concat(Zeile3).Concat(Zeile4).Concat(Zeile5).Concat(Zeile6)).ToArray();
                if (inputLoesung.SequenceEqual(spielstandvergleich))
                    break;


                string inRow;
                string inCollumn;
                string inNumber;
                Console.WriteLine("Geben Sie Ihren nächsten Spielzug ein. Zeile:");
                inRow = Console.ReadLine();
                Console.WriteLine("Reihe");
                inCollumn = Console.ReadLine();
                Console.WriteLine("Loesungszahl");
                inNumber=Console.ReadLine();

                int loesungscheck = loesung[(int.Parse(inRow))-1, (int.Parse(inCollumn))-1];
                if (int.Parse(inNumber) == loesungscheck)
                {
                    spielvorgabe[int.Parse(inRow)-1, int.Parse(inCollumn)-1] = int.Parse(inNumber);
                    Console.Clear();
                    Console.WriteLine("TipTop Spielzug!");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Leider falsch...");
                }
                
                
            }

            Console.Clear();
            Console.WriteLine("Gratuliere Ihnen zum Sieg!");
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
