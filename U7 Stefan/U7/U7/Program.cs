using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U7
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
        Start:
            Console.Clear();
            int i = 0;
            Console.WriteLine(@"Wählen Sie ein Program:
1x1 lernen              [1]
Zufallszahl ausgeben    [2]
Program beenden         [3]");
            try
            {
                input = int.Parse(Console.ReadLine());
            }
            catch (SystemException)
            {
                Console.Clear();
                Console.WriteLine("Ungültige Eingabe");
                goto Start;
            }
            switch(input)
            {
                case 1:
                    while (i <= 10)
                    {
                       
                    FalscheAntwort:
                        int antwort;
                        try
                        {
                            Console.WriteLine($"{i} * 7 = ?");
                            antwort = int.Parse(Console.ReadLine());                           
                        }
                        catch(SystemException)
                        {
                            Console.WriteLine("Ungültige Eingabe");
                            goto FalscheAntwort;
                        }
                        if (antwort == i * 7)
                        {
                            Console.WriteLine("Bravo!");
                            i++;
                        }
                        else
                        {
                            Console.WriteLine("Falsche Antwort... Versuch's nochmal");
                            goto FalscheAntwort;
                        }                    
                    }
                    Console.Clear();
                    Console.WriteLine("Geschafft! Du Mathekönig!!\nPress any key to continue");
                    Console.ReadLine();
                    goto Start;
                    
                case 2:
                    Random rnd = new Random();
                    int randomNumber = rnd.Next(1, 10);
                    Console.WriteLine($@"Zufallszahl: {randomNumber}
Press any key to continue!");
                    Console.ReadLine();
                    goto Start;
                case 3:
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine($"Ungültige Eingabe: {input}! nur Zahlen zwischen 1 und 2 zulässig!");
                    goto Start;                  
            }      
        }
    }
}
