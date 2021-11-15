using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Addresses.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var menuText = @"Adressbuch
1 - Adresse eingeben
2 - Alle Adressen ausgeben
3 - Nach Personen suchen
4 - Adressen nach vollen Namen sortieren
5 - Adressen nach Nachnamen und dann nach Vornamen sortieren

0 - Programm beenden
Bestätigen Sie Ihre Eingabe mit der Enter-Taste";

            //neues Adressbuch mit 3 Adressen anlegen
            var addressBook = new AddressBook 
            { 
                new Address
                {
                    FirstName = "Max",
                    LastName = "Mustermann",
                    Road = "Steyrergasse",
                    ZipCode = 8010,
                    Town = "Graz"
                },
                new Address
                {
                    FirstName = "Maria",
                    LastName = "Musterfrau",
                    Road = "Petersgasse",
                    ZipCode = 8010,
                    Town = "Graz"
                },
                new Address
                {
                    FirstName = "Benjamin",
                    LastName = "Beispiel",
                    Road = "Kopernikusgasse",
                    ZipCode = 8010,
                    Town = "Graz"
                },
            };

            char input;
            do
            {
                Console.Clear();
                Console.WriteLine(menuText);
                Console.WriteLine();

                input = (char)Console.Read();
                Console.ReadLine(); //ein Linebreak befindet sich durch das Bestätigen mit Enter bei Console.Read() noch im Inputstream
                switch (input) 
                {
                    case '0': return; //Wenn 0 eingegeben Programm beenden
                    #region U5.3
                    case '1':
                        {
                            addressBook.AddAddress();
                        } break;
                    case '2':
                        {
                            Console.WriteLine(addressBook);
                            Console.ReadLine();
                        }
                        break;
                    case '3': 
                        {
                            Console.WriteLine("Suchbegriff eingeben: (bei vollen Namen: <Vorname> <Nachname>)");
                            var result = addressBook.SearchAfter(Console.ReadLine().Trim());    //Trim entfernt WhiteSpace an Anfang und Ende des strings

                            Console.WriteLine("Suchergebnis:");
                            Console.WriteLine(result.Count < 1          
                                ? "Nichts gefunden"
                                : string.Join($"{Environment.NewLine}-------------------------------------{Environment.NewLine}", result));
                            //Kurzschreibweise für ifs: <logische Bedingung> ? <Wert wenn true> : <Wert wenn false>
                            //Wenn nichts gefunden wurde wird entsprechende Ausgabe gemacht
                            //string.Join: siehe AddressBook.ToString()

                            Console.ReadLine();
                        } break;
                    #endregion
                    case '4':
                        {
                            //Adressen mit FullNameComparer als Sortierkriterium sortieren
                            addressBook.Sort(new FullNameComparer());
                            Console.WriteLine(addressBook);
                            Console.ReadLine();
                        }
                        break;
                    case '5':
                        {
                            //Adressen mit LastNameComparer als Sortierkriterium sortieren
                            addressBook.Sort(new LastNameComparer());
                            Console.WriteLine(addressBook);
                            Console.ReadLine();
                        }
                        break;

                    //Ursprüngliche Reihenfolge der Adressen geht nach erstem Sortieren verloren
                    //Mit dieser Vorgehensweise umständlich zu Umgehen, da für jede Sortieroperation die Collection mit Adressen kopiert werden müsste
                    //
                    //Alternative: Linq (Language integrated queries)
                    //OrderBy(q => ...): Linq-Methode zum Sortieren von Collections, Lambda-Expression als Parameter
                    //                   q repräsentiert Element in Collection, sortiert Collection basierend auf dem von q abhängigen Ausdruck nach =>
                    //					 gibt Collection von Typ IOrderedEnumerable zurück
                    //ThenBy(q => ...): Linq-Methode um IOrderedEnumerables mit weiteren Sortierkriterien zu versehen, Lambda-Expression als Parameter
                    //                  q repräsentiert Element in Collection, fügt neues Sortierkriterium basierend auf dem von q abhängigen Ausdruck nach =>
                    //					gibt Collection von Typ IOrderedEnumerable zurück
                    //ToList(): IEnumerable<T> wird in List<T> umgewandelt
                    //
                    //funktioniert ohne IComparable, IComparer o.ä., man erhält sortierte Collection als eigenes Objekt => alte Collection mit alter Reihenfolge bleibt erhalten
                    //verwendet anderen Sortieralgorithmus als List<T>.Sort() bzw. Array.Sort()
                    //verwendet stable Quicksort ggü. unstable Introsort von Array.Sort() (stable => "gleiche" Elemente behalten gleiche Reihenfolge)
                    //gleiche Average-Performance, aber schlechtere Worst-Case-Performance ggü. Array.Sort()
                    //
                    //var sortedAddresses = addressBook.OrderBy(q => q.LastName).ThenBy(q => q.FirstName).ToList();

                    default: Console.WriteLine("Ungültige Eingabe"); break;
                }
            }
            while (true);
        }
    }
}
