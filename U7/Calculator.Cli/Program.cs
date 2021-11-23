using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Cli
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            Console.WriteLine("------------------------------Taschenrechner------------------------------");
            var num1 = ReadDoubleFromConsole("Geben Sie die erste Zahl ein.");
            var num2 = ReadDoubleFromConsole("Geben Sie die zweite Zahl ein.");
            switch (ReadOperationFromConsole()) 
            {
                case '*': Console.WriteLine($"{num1} * {num2} = {num1 * num2}"); break;
                case '+': Console.WriteLine($"{num1} + {num2} = {num1 + num2}"); break;
                case '-': Console.WriteLine($"{num1} - {num2} = {num1 - num2}"); break;
                case '/':
                    if (num2 == 0)
                        Console.WriteLine("Fehler: Division durch 0.");
                    else
                        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    break;
            }

            Console.ReadLine();
        }

        private static char ReadOperationFromConsole() 
        {
            string input;
            var validOperations = new List<string> { "*", "+", "-", "/" }; //Collection mit allen zulässigen Operatoren
            do
            {
                Console.WriteLine("Wähle einen Operator:");
                input = Console.ReadLine().Trim();  //string.Trim() entfernt WhiteSpace an Anfang und Ende des strings
            }
            while (!validOperations.Contains(input)); //Wenn input in Collection enthalten ist Eingabe gültig

            //input als string, weil Userinput nicht zwingend nur 1 Character sein muss
            //wenn input gültig aber sicher nur 1 character => deswegen Rückgabe als char
            //Zugriff auf ersten (und einzigen) Character im string wie bei Array weil string IEnumerable<char> implementiert
            return input[0]; 
        }

        //Methode um sicher double-Input zu erhalten
        private static double ReadDoubleFromConsole(string message)
        {
            double retValue;
            string input;
            do
            {
                Console.WriteLine(message);
                input = Console.ReadLine();
            }
            //double.TryParse(string input, out double parsedValue):
            //Methode zum überprüfen, ob Parsen überhaupt möglich ist, gibt true zurück wenn input numerisch ist und geparsed werden kann, false wenn nicht
            //geparster Wert wird über out-Parameter zurückgegeben
            while (!double.TryParse(input, out retValue));

            return retValue;
        }
    }
}
