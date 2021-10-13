using System;

namespace ReadWriteInfo.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first name and press Return");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter last name and press Return");
            var lastName = Console.ReadLine();
            Console.WriteLine("Enter address and press Return");
            var address = Console.ReadLine();
            //Formatierter Output
            //@-Prefix vor string für Multiline-Strings (anderes Escape-Pattern)
            //$-Prefix um in {} Expressions verwenden zu können, außerdem Performancevorteil ggü. Konkatenieren mit +
            Console.WriteLine(@$"Your address:
*****************************
{firstName}_{lastName}
{address}");
        }
    }
}
