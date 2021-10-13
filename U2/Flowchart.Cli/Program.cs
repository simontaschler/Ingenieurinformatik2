using System;

namespace Flowchart.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer between 1 and 4");
            var input = Console.ReadLine();

            if (int.TryParse(input, out var a))
            {
                switch (a) 
                {
                    case 1: Console.WriteLine(a + 1); break;
                    case 2: Console.WriteLine(a % 2); break;
                    case 3: Console.WriteLine(a / 2); break;
                        //Nachkommastelle(n) werden ignoriert und verworfen durch ganzzahligen Datentyp
                    case 4: Console.WriteLine(Math.Pow(a, 32).ToString("N0")); break;
                        //4^32 = 2^64, was größer als MaxValue vom standardmäßigen Int32 ist
                        //auch höchste MaxValue eines ganzzahligen Datentyps UInt64 ist nur 2^64 - 1,
                        //deshalb muss double verwendet werden
                    default: Console.WriteLine("Error: Your input is out of bounds"); break;
                }
            }
            else 
            {
                Console.WriteLine("Error: Your input did not match valid format.");
            }

            Console.WriteLine("Enter an integer");
            input = Console.ReadLine();

            if (int.TryParse(input, out var b)) 
            {
                if (a % 2 == 0) 
                {
                    Console.WriteLine("Even");
                }
                else 
                {
                    Console.WriteLine("Odd");
                    Console.WriteLine(a > b
                        ? "a greater than b"
                        : "a less than b");
                }
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine("Error: Your input did not match valid format.");
            }
        }
    }
}
