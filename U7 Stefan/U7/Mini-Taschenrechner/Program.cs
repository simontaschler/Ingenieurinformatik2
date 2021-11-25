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
            decimal input1;     //Festlegen der input Werte als decimal da dividiedbyZero Exception auf decimal ausgelegt sind
            decimal input2;
            string inputOperator;
            decimal ergebnis;
            
        Start:  
            Console.WriteLine("**********Taschenrechner**********");
        Eingabe1:   //Sprungmarke Eingabe 1
            try         //Try catch zum Abfangen möglicher falscher inputs (non numeric)
            {                
                Console.WriteLine("Geben Sie die erste Zahl ein");
                input1 = decimal.Parse(Console.ReadLine());     //Parsen des input strings als decimal
            }
            catch(FormatException)  //Format Exception falls non nummeric input
            {
                Console.WriteLine("Ungültige Eingabe! Nur Zahlen erlaubt");
                goto Eingabe1;      //gehe zur Sprungmarke Eingabe1 falls die Eingabe ungültig war
            }
            Console.Clear();
        Eingabe2:   //Sprungmarke Eingabe 2
            try         //Äquivalent zur Eingabe des 1. Parameters
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
        EingabeOperator:        //Sprungmarke EingabeOperator
            Console.WriteLine("Geben Sie einen Rechenoperator ein!");
            inputOperator = Console.ReadLine();
            switch(inputOperator)       //Switch um die jeweilige Rechenoperation auszuführen
            {
                case "*":
                    ergebnis = input1 * input2;
                    break;
                case "/":                   
                     try        //Bei der Division ist auf die divided by zero Exception zu achten
                    {                   
                        ergebnis = input1 / input2;
                    }
                    catch (DivideByZeroException)
                    {
                        Console.Clear();
                        Console.WriteLine("Division durch 0!");
                        goto Start;         //Im Fall einer Division durch 0 springt das Program zur start Sprungmarke 
                    }                        
                    
                    break;
                case "+":
                    ergebnis = input1 + input2;
                    break;
                case "-":
                    ergebnis = input1 - input2;
                    break;
                default:        //Wurde eien ungülltige Eingabe getätigt springt das Program zur EingabeOperator Sprungmarke und ermöglicht dem user daher eine neue Operatoreingabe
                    Console.Clear();
                    Console.WriteLine("Ungültige Eingabe! Zulässig sind * / + und -");
                    goto EingabeOperator;                   
            }
            Console.WriteLine($"{input1} {inputOperator} {input2} = {ergebnis}");       //Ausgabe des Ergebnises
            Console.ReadLine();
        }
    }
}
