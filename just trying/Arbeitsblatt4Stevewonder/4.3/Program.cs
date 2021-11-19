using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Auswahl welche Methode ausgeführt weren soll.
            Console.Write("Geben Sie ein welche Methode sie ausführen möchten.\nMethode 1: 1\nMethode 2: 2\n");
            string input = Console.ReadLine();

            if (int.Parse(input) == 1)
                Methode1();
            else
                if (int.Parse(input) == 2)
                Methode2();
            else
                Console.WriteLine("ungülltige Eingabe!\nStarten Sie das Programm neu!");
                Console.Read();
        }

        static void Methode1()
        {
            int a = 1;
            int b = 1;
            while (a < 5)
            {
                Console.WriteLine("Äußere Schleife: a= " + a);
                while (b < 5)
                {
                    if (b == 3)
                    {
                        Console.WriteLine("Innere Schleife: break");
                break;
                    }
                    else
                    {
                        Console.WriteLine("Innere Schleife: b= " + b);
                        b++;
                    }
                }
                
                a++;
                b = 1;

            }
            Console.WriteLine("End! \na=" + a + "\nb=" + b);
            Console.Read();

        }
        static void Methode2()
        {
        int a = 1;
        int b = 1;
            while (a<5)
            {
                Console.WriteLine("Äußere Schleife: a= " + a);
                while (b<5)
                {
                    if (b == 3)
                    {
                        Console.WriteLine("Innere Schleife: continue");
                    }
                    else
                    {
                        Console.WriteLine("Innere Schleife: b= " + b);
                        b++;
                    }
                }
                a++;
                b = 1;          
                        
            }
            Console.WriteLine("End! \na=" + a + "\nb=" + b);
            Console.Read();


        }
    
    }

}
