using System;

namespace HelloWorld.Lib
{
    public static class Printer
    {
        public static void PrintHelloWorld() => 
            Console.WriteLine("Hello World! (from class within other project and namespace)");
    }
}
