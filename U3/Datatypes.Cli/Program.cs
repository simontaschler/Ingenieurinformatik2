using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var charIndex = Console.Read();
            Console.WriteLine($"{(char)charIndex}: {charIndex}"); //$= interpolated string (Rechnen im string möglich)

            double charDub = charIndex;
            charDub *= 1.3;

            var floatNum = 2.56F;
            Console.WriteLine($"{charDub} + {floatNum} = {charDub + floatNum}");
            //gibt kein mathemtaisch exaktes Ergebnis, weil double und float floating point data types sind
            //Kann durch Verwendung von System.Decimal umgangen werden:
            //Console.WriteLine($"{charDub} + {floatNum} = {(decimal)charDub + (decimal)floatNum}");

            Console.WriteLine($"int: {(int)(charDub + floatNum)}");
            
            //Unterschied implizite/explizite Typumwandlungen:
            //implizit: kein besonderer Syntax, Umwandlung immer erfolgreich, kein Datenverlust
            //explizit: cast erforderlich

            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
