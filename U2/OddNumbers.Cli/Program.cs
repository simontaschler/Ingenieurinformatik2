using System;
using System.Collections.Generic;

namespace OddNumbers.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var oddNumbers = new List<int>();
            for (var i = 1; i <= 21; i += 2)
                oddNumbers.Add(i);

            var output = string.Join(' ', oddNumbers);
            oddNumbers.Reverse();
            output += $" {string.Join(' ', oddNumbers)}";
            Console.WriteLine(output);
        }
    }
}
