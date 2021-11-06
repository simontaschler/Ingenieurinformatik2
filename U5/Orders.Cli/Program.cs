using System;

namespace Orders.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(new Order("Asia Wok", 6.9F));
            Console.WriteLine(new Order("Hamburger", 10F));
            Console.WriteLine(new Order(5F));
            Console.WriteLine(new Order("Kuchen"));
            Console.WriteLine(new Order("Lasagna", 4.2F));
        }
    }
}
