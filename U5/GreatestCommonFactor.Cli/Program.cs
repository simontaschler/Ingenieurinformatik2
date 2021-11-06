using System;

namespace GreatestCommonFactor.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 98;
            var b = 56;

            Console.WriteLine($"Recursive Calculation: Greatest common factor between {a} and {b} is {GCF_recursive(a,b)}");
            Console.WriteLine($"Iterative Calculation: Greatest common factor between {a} and {b} is {GCF_iterative(a,b)}");
        }

        static int GCF_recursive(int a, int b) 
        {
            if (b == 0)
                return a;
            return GCF_recursive(b, a % b);
        }

        static int GCF_iterative(int a, int b)
        {
            if (a == b)
            {
                return a;
            }
            else if (b > a) 
            {
                var cache = a;
                a = b;
                b = cache;
            }

            int i;
            for (i = b; a % i != 0 || b % i != 0; i--);
            return i;
        }

    }
}
