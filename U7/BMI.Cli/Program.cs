using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace BMI.Cli
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            #region Normalgewichte aus Angabe
            //Tabelle aus Angabe als zwei SortedLists (eine für Männer und eine für Frauen) instanzieren
            //als SortedList mit Obergrenze des Intervalls des Alters damit später möglichst einfach auf zu verwendende BMI Intervalle zugegriffen werden kann
            //SortedList<TKey, TValue>: Collection, die sich bei Änderungen selbst anhand des Keys(i.d.F. Alter) sortiert
            //                          Zugriff deswegen nur auf sortierte Sequenz möglich
            //                          TKey als Datentyp des Keys, nach dem sortiert wird
            //                          TValue als Datentyp des zu speichernden Wertes (i.d.F. Range<decimal> für Intervall des BMIs)
            //decimal statt double, weil DivideByZeroException nicht für floating point Types wie double designed wurde und deswegen keine Exception geworfen wird,
            //bei Division durch 0 mit decimal hingegen schon
            var maleNormWeight = new SortedList<int, Range<decimal>> 
            {
                { 16, new Range<decimal>(19, 24) },
                { 18, new Range<decimal>(20, 25) },
                { 24, new Range<decimal>(21, 26) },
                { 34, new Range<decimal>(22, 27) },
                { 54, new Range<decimal>(23, 28) },
                { 64, new Range<decimal>(24, 29) },
                { 90, new Range<decimal>(25, 30) }
            };

            var femaleNormWeight = new SortedList<int, Range<decimal>> 
            {
                { 24, new Range<decimal>(19, 24) },
                { 34, new Range<decimal>(20, 25) },
                { 44, new Range<decimal>(21, 26) },
                { 54, new Range<decimal>(22, 27) },
                { 64, new Range<decimal>(23, 28) },
                { 90, new Range<decimal>(25, 30) }
            };
            #endregion

            var results = new ArrayList();
            while(results.Count < 3) //Schleife iteriert bis 3 vollständige Berechnungen durchgeführt wurden
            {
                var weight = ReadDecimalFromConsole("Geben Sie ein Körpergewicht [kg] ein!");
                var height = ReadDecimalFromConsole("Geben Sie eine Körpergröße [m] ein!");

                try 
                {
                    var bmi = weight / (height * height);

                    var age = ReadIntFromConsole("Geben Sie ein Alter ein!");
                    var sex = ReadSexFromConsole("Geben Sie das Geschlecht [M/F] ein!");

                    var normWeight = sex == 'M'     //Conditional Expression (kurzschreibweise für ifs): <logische Bedingung> ? <Wert wenn true> : <Wert wenn false>
                        ? maleNormWeight
                        : femaleNormWeight;

                    //First(q => <true/false>): Linq-Methode um erstes Element, das Bedingung erfüllt zu erhalten, Lambda-Expression als Parameter
                    //                          q repräsentiert Element in Collection, gibt erstes Element für die der Ausdruck nach => true ist heraus
                    //First kann hier verwendet werden, weil normWeight eine SortedList ist, bei der die Obergrenze des Altersintervall als Key verwendet wurde
                    //Deswegen ist erstes Element, bei dem Key >= Alter automatisch der richtige Altersintervall
                    var bmiRange = normWeight.First(q => q.Key >= age).Value;
                    var bmiComparisonResult = bmiRange.CompareToValue(bmi);

                    #region String mit Ergebnis zusammenstellen
                    string bmiClassification;
                    if (bmiComparisonResult == 0)
                        bmiClassification = "Normalgewicht";
                    else if (bmiComparisonResult < 0)
                        bmiClassification = "Untergewicht";
                    else
                        bmiClassification = "Übergewicht";

                    //$-Prefix vor string (interpolated string) um in {} Expressions verwenden zu können, außerdem Performancevorteil ggü. Konkatenieren mit +
                    //<double>:N2: double Wert als string mit 2 Nachkommastellen formatieren
                    results.Add($"{sex}/{age}: {height:N2} m, {weight:N1} kg, BMI: {bmi:N2} => {bmiClassification}");
                    #endregion
                }
                catch (DivideByZeroException e) //Exception tritt auf, wenn height = 0
                {
                    Console.WriteLine(e.Message);
                }
            }

            foreach (var result in results)
                Console.WriteLine(result);

            Console.ReadLine();
        }

        //Methode um sicher decimal-Input zu erhalten
        private static decimal ReadDecimalFromConsole(string message)
        {
            while (true)
            {
                try 
                {
                    Console.WriteLine(message);
                    var input = decimal.Parse(Console.ReadLine());
                    if (input >= 0)     //>= 0 statt > damit DivideByZeroException später auftreten kann
                        return input;
                    else
                        Console.WriteLine("Werte < 0 nicht zulässig");
                }
                catch (FormatException e) //Exception tritt bei decimal.Parse auf wenn Rückgabe von Console.ReadLine() nicht geparsed werden kann
                {
                    Console.WriteLine(e.Message);
                }
            }

            #region Alternative: verhindert Auftreten von Exception
            //double retValue;
            //string input;
            //do
            //{
            //    Console.WriteLine(message);
            //    input = Console.ReadLine();
            //}
            ////double.TryParse(string input, out double parsedValue):
            ////Methode zum überprüfen, ob Parsen überhaupt möglich ist, gibt true zurück wenn input numerisch ist und geparsed werden kann, false wenn nicht
            ////geparster Wert wird über out-Parameter zurückgegeben
            //while (!double.TryParse(input, out retValue) && retValue > 0);

            //return retValue;
            #endregion
        }

        //Methode um sicher double-Input zu erhalten
        private static int ReadIntFromConsole(string message)
        {
            while (true)
            {
                try 
                {
                    Console.WriteLine(message);
                    var input = int.Parse(Console.ReadLine());
                    if (input > 15 && input < 91) //Angabe deckt Alter von 16 bis 90 ab
                        return input;
                    else
                        Console.WriteLine("Nur Werte zwischen 16 und 90 zulässig!");
                }
                catch (FormatException e) //Exception tritt bei int.Parse auf wenn Rückgabe von Console.ReadLine() nicht geparsed werden kann
                {
                    Console.WriteLine(e.Message);
                }
            }

            #region Alternative: verhindert Auftreten von Exception
            //int retValue;
            //string input;
            //do
            //{
            //    Console.WriteLine(message);
            //    input = Console.ReadLine();
            //}
            ////int.TryParse(string input, out int parsedValue):
            ////Methode zum überprüfen, ob Parsen überhaupt möglich ist, gibt true zurück wenn input numerisch ist und geparsed werden kann, false wenn nicht
            ////geparster Wert wird über out-Parameter zurückgegeben
            //while (!int.TryParse(input, out retValue) && retValue > 0);

            //return retValue;
            #endregion
        }

        //Methode um sicher Geschlecht einzulesen
        private static char ReadSexFromConsole(string message)
        {
            string input;
            var validOperations = new List<string> { "M", "F" }; //Collection mit allen zulässigen Operatoren
            do
            {
                Console.WriteLine(message);
                input = Console.ReadLine().Trim().ToUpper();  //string.Trim() entfernt WhiteSpace an Anfang und Ende des strings
                                                              //string.ToUpper() kovertiert zu string mit nur UpperCase Characters
            }
            while (!validOperations.Contains(input)); //Wenn input in Collection enthalten ist Eingabe gültig

            //input als string, weil Userinput nicht zwingend nur 1 Character sein muss
            //wenn input gültig aber sicher nur 1 character => deswegen Rückgabe als char
            //Zugriff auf ersten (und einzigen) Character im string wie bei Array weil string IEnumerable<char> implementiert
            return input[0];
        }

    }
}
