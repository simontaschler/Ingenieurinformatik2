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
                    default: Console.WriteLine("Ungültige Eingabe"); break;
                }
            }
            while (true);
        }
    }
}
