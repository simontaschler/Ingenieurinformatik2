using System;

namespace Orders.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(new Order("Asia Wok", 6.9F)); //erster Ctor wird verwendet, optionaler Paramater wird übergeben
            Console.WriteLine(new Order("Hamburger", 10F)); //erster Ctor wird verwendet, optionaler Paramater wird übergeben
            Console.WriteLine(new Order(5F));               //zweiter Ctor wird verwendet, optionaler Paramater wird übergeben
            Console.WriteLine(new Order("Kuchen"));         //erster Ctor wird verwendet, optionaler Paramater wird nicht übergeben
            Console.WriteLine(new Order());                 //zweiter Ctor wird verwendet, optionaler Paramater wird nicht übergeben
        }
    }
}
