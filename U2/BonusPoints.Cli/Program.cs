using System;

namespace BonusPoints.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Console.WriteLine("Enter first player's points");
                var player1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second player's points");
                var player2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter third player's points");
                var player3 = int.Parse(Console.ReadLine());

                var sum = player1 + player2 + player3;
                Console.WriteLine($"Total of {sum} points");
            }
            //Abfangen von Fehlern beim Parsen des Userinputss
            catch (FormatException) 
            {
                Console.WriteLine("Error: Input did not numeric format");
            }
            catch (OverflowException) 
            {
                Console.WriteLine("Error: Input out of bounds of Int32");
            }
        }
    }
}
