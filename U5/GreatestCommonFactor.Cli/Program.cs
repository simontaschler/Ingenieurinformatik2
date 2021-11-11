using System;

namespace GreatestCommonFactor.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 98;
            var b = 56;

            //$-Prefix um in {} Expressions verwenden zu können, außerdem Performancevorteil ggü. Konkatenieren mit +
            Console.WriteLine($"Recursive Calculation: Greatest common factor between {a} and {b} is {GCF_recursive(a,b)}");
            Console.WriteLine($"Iterative Calculation: Greatest common factor between {a} and {b} is {GCF_iterative(a,b)}");
        }

        static int GCF_recursive(int a, int b) 
        {
            if (b == 0)
                return a; //sobald b = 0, ist GGT mit a gefunden
            return GCF_recursive(b, a % b); //Methode ruft sich selbst erneut mit anderen Parametern auf
        }

        static int GCF_iterative(int a, int b)
        {
            if (a == b) //Wenn beide gleich groß, dann beide gleich dem GGT
            {
                return a;
            }
            else if (b > a) //Falls b größer a Zuordnung vertauschen
            {
                var cache = a;
                a = b;
                b = cache;
            }

            int i;
            for (i = b; a % i != 0 || b % i != 0; i--); //Laufvariable i startet beim kleineren Wert und wird so lange um 1 verkleinert, bis a % i = 0 und b % i = 0
            return i;
        }

    }
}
