using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLearner.Cli
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            var option = GetOptionInput();

            if (option == 1)
                HandleFirstOption();
            else
                HandleSecondOption();

            Console.ReadLine();
        }

        //Methode, die für Abarbeitung von Option 1 zuständig ist
        private static void HandleFirstOption() 
        { 
            for (var i = 0; i <= 10; i++) 
            {
                var expectedInput = 7 * i;
                var attempts = 0;
                do //do-while iteriert so lange, bis numerischer Input, der dem erwartetem Wert entspricht, getätigt wurde
                {
                    if (attempts > 0)   //Wenn Versuche größer 1, muss zuvor falsche Eingabe getätigt worden sein
                        Console.WriteLine("Das ist leider nicht richtig! Versuche es nochmal.");
                    //$-Prefix vor string (interpolated string) um in {} Expressions verwenden zu können, außerdem Performancevorteil ggü. Konkatenieren mit +
                    Console.WriteLine($"Was ist {i} x 7 = ?");
                    attempts++;
                }
                //int.TryParse(string input, out int parsedValue):
                //Methode zum überprüfen, ob Parsen überhaupt möglich ist, gibt true zurück wenn input numerisch ist und geparsed werden kann, false wenn nicht
                //geparster Wert wird über out-Parameter zurückgegeben
                while (!int.TryParse(Console.ReadLine(), out var resultInput) || resultInput != expectedInput);
                Console.WriteLine("Bravo!");
            }
        }

        //Methode, die für Abarbeitung von Option 2 zuständig ist
        private static void HandleSecondOption() =>
            //$-Prefix vor string (interpolated string) um in {} Expressions verwenden zu können, außerdem Performancevorteil ggü. Konkatenieren mit +
            Console.WriteLine($"Zufallszahl zwischen 0 und 10: {new Random().Next(0, 10)}");

        private static int GetOptionInput() 
        {
            //Endlosschleife wird verlassen sobald return-Statement aufgerufen wurde
            while(true)
            {
                Console.WriteLine("Welche Option möchten Sie wählen? 1 oder 2");
                //int.TryParse(string input, out int parsedValue):
                //Methode zum überprüfen, ob Parsen überhaupt möglich ist, gibt true zurück wenn input numerisch ist und geparsed werden kann, false wenn nicht
                //geparster Wert wird über out-Parameter zurückgegeben
                if (int.TryParse(Console.ReadLine(), out var optionInput) && (optionInput == 1 || optionInput == 2))
                    return optionInput;
                Console.WriteLine("Sie müssen entweder 1 oder 2 eintippen");
            }
        }
    }
}
