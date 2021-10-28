using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensa.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var validDishIndexes = new List<char> { '1', '2', '3', '4', '5' };
            var menuText = @"Speisekarte
1 - Menü A       6.50€
2 - Menü B       5.20€
3 - Salat        0.18€/10g
4 - Suppe        1.00€ im Menü/1.50€
5 - Dessert      2.20€

0 - Bestellung abschließen
Geben Sie Ihre Bestellung auf, und bestätigen Sie Ihre Eingabe mit der Enter- Taste";
            var shoppingCart = new Dictionary<char, int>(); //Dictionary, das ShoppingCart in Form von Produktindex und Menge abspeichert

            Console.OutputEncoding = System.Text.Encoding.UTF8; //Damit € Symbol richtig in Konsole angezeigt wird

            //Schleife, die solange Produkte einliest bis 0 eingegeben wird
            //würde mit string auch funktionieren, character [char] ist beim Arbeiten mit nur einem character optimaler
            char input;
            do
            {
                Console.Clear();
                Console.WriteLine(menuText);
                Console.WriteLine();

                input = (char)Console.Read();
                if (validDishIndexes.Contains(input))
                {
                    //ContainsKey --> true: +1(++) false --> neu anlegen mit Wert 1
                    if (shoppingCart.ContainsKey(input))
                        shoppingCart[input]++;
                    else
                        shoppingCart.Add(input, 1);
                }
            }
            while (input != '0');

            //Schleife die so lange iteriert, bis User gültigen Input getätigt hat
            var validIsStudentInput = new List<char> { 'J', 'N', 'j', 'n' };
            char isStudentInput;
            do
            {
                Console.Clear();
                Console.WriteLine("Sind Sie Studierender? [J/N]");
                isStudentInput = (char)Console.Read();
            }
            while (!validIsStudentInput.Contains(isStudentInput));

            var isStudent = isStudentInput == 'J' || isStudentInput == 'j';
            var totalPrice = GetTotalPrice(shoppingCart, isStudent);
            Console.Clear();
            Console.WriteLine($"Der Gesamtbetrag beläuft sich auf {totalPrice:N2}€."); //N2 --> formatierung auf number mit zwei Nachkommasrtellen

            Console.ReadLine();
            Console.ReadLine();
        }
        
        //Methode zum Berechnen des Gesamtpreises
        static double GetTotalPrice(Dictionary<char,int> shoppingCart, bool isStudent = false) 
        {
            var total = 0.0;
            var rnd = new Random();
            var menuQuantity = 0;
            //trygetvalue gibt boolean aus, out quantity gibt die Anzahl aus
            if (shoppingCart.TryGetValue('1', out var quantity)) 
            {
                menuQuantity += quantity;
                total += quantity * 6.5;
            }
            if (shoppingCart.TryGetValue('2', out quantity)) 
            {
                menuQuantity += quantity;
                total += quantity * 5.2;
            }
            if (shoppingCart.TryGetValue('3', out quantity)) 
                total += quantity * 0.18 * rnd.Next(8, 12);
            if (shoppingCart.TryGetValue('4', out quantity)) 
            {
                //Kurzschreibweise einer if Abfrage [logische Bedingung?Wert wenn true: Wert wenn false]
                total += quantity <= menuQuantity
                    ? quantity*1 //1€ für Suppen im Menü 
                    : menuQuantity*1 + (quantity - menuQuantity) * 1.5; //Jede Suppe die zu keinem Menü gehört kostet 1,5€
            }
            if (shoppingCart.TryGetValue('5', out quantity)) 
                total += quantity * 2.2;

            if (isStudent)
                total *= 0.9;

            return Math.Round(total, 2); //return gibt den Rückgabewert einer Methode vor, in diesem Fall double total auf zwei Stellen gerundet
        }
    }
}
