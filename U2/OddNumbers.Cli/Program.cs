using System;
using System.Collections.Generic;

namespace OddNumbers.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var oddNumbers = new List<int>();
            //Liste mit ersten 10 ungeraden Zahlen befüllen
            for (var i = 1; i <= 21; i += 2)
                oddNumbers.Add(i);

            //erste Hälfte des Outputstrings zusammenbauen
            var output = string.Join(' ', oddNumbers);
            //Reihenfolge der Elemente in Liste invertieren
            oddNumbers.Reverse();
            //zweite Hälfte der Ausgabe zusammenbauen
            output += $" {string.Join(' ', oddNumbers)}";
            Console.WriteLine(output);
        }
    }
}
