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
            Console.WriteLine($"{firstName}_{lastName}, {address}");
        }
    }
}
