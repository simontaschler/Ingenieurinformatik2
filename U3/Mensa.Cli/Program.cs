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

0 - Bestellung abschließen";
            var shoppingCart = new Dictionary<char, int>(); //Dictionary, das ShoppingCart in Form von Produktindex und Menge abspeichert

            Console.OutputEncoding = System.Text.Encoding.UTF8; //Damit € Symbol richtig in Konsole angezeigt wird

            //Schleife, die solange Produkte einliest bis 0 eingegeben wird
            char input;
            do
            {
                Console.Clear();
                Console.WriteLine(menuText);
                Console.WriteLine();

                input = (char)Console.Read();
                if (validDishIndexes.Contains(input))
                {
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
            Console.WriteLine($"Der Gesamtbetrag beläuft sich auf {totalPrice:N2} €.");

            Console.ReadLine();
            Console.ReadLine();
        }
        
        //Methode zum Berechnen des Gesamtpreises
        static double GetTotalPrice(Dictionary<char,int> shoppingCart, bool isStudent = false) 
        {
            var total = 0.0;
            var rnd = new Random();
            var menuQuantity = 0;

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
                total += quantity <= menuQuantity
                    ? quantity
                    : menuQuantity + (quantity - menuQuantity) * 1.5;
            }
            if (shoppingCart.TryGetValue('3', out quantity)) 
                total += quantity * 2.2;

            if (isStudent)
                total *= 0.9;

            return (float)Math.Round(total, 2);
        }
    }
}
