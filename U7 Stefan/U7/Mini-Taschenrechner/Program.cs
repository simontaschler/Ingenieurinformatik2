using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal input1;
            decimal input2;
            string inputOperator;
            decimal ergebnis;
            
        Start:  
            Console.WriteLine("**********Taschenrechner**********");
        Eingabe1:
            try 
            {                
                Console.WriteLine("Geben Sie die erste Zahl ein");
                input1 = decimal.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Ungültige Eingabe! Nur Zahlen erlaubt");
                goto Eingabe1;
            }
            Console.Clear();
        Eingabe2:
            try
            {
                Console.WriteLine("Geben Sie die zweit Zahl ein");
                input2 = decimal.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Ungültige Eingabe! Nur Zahlen erlaubt");
                goto Eingabe2;
            }
            Console.Clear();
        EingabeOperator:
            Console.WriteLine("Geben Sie einen Rechenoperator ein!");
            inputOperator = Console.ReadLine();
            switch(inputOperator)
            {
                case "*":
                    ergebnis = input1 * input2;
                    break;
                case "/":                   
                     try
                    {
                        ergebnis = input1 / input2;
                    }
                    catch (DivideByZeroException)
                    {
                        Console.Clear();
                        Console.WriteLine("Division durch 0!");
                        goto Start;
                    }                        
                    
                    break;
                case "+":
                    ergebnis = input1 + input2;
                    break;
                case "-":
                    ergebnis = input1 - input2;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Ungültige Eingabe! Zulässig sind * / + und -");
                    goto EingabeOperator;                   
            }
            Console.WriteLine($"{input1} {inputOperator} {input2} = {ergebnis}");
            Console.ReadLine();
        }
    }
}
