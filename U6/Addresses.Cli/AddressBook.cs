using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addresses.Cli
{
    internal class AddressBook : List<Address>
        //Adressbuch als Derivat von List<Address>, weil Adressbuch Liste von Adressen mit neuen Methoden sein soll
        //Erübrigt Problem bei einer Variante mit Liste als Property, dass ein Objekt Addressbuch ohne Liste existieren kann
    {
        //Methode zum Hinzufügen von Adressen
        internal void AddAddress() 
        {
            Console.Clear();
            //Einlesen der Adressdaten
            Console.WriteLine("Geben Sie den Vornamen ein");
            var firstName = Console.ReadLine().Trim();
            Console.WriteLine("Geben Sie den Nachanmen ein");
            var lastName = Console.ReadLine().Trim();
            Console.WriteLine("Geben Sie die Straße ein");
            var road = Console.ReadLine().Trim();
            Console.WriteLine("Geben Sie die PLZ ein");
            var zipCode = ReadIntFromConsole();
            Console.WriteLine("Geben Sie den Ort ein");
            var town = Console.ReadLine().Trim();

            //neue Adresse anlegen und der Liste hinzufügen
            Add(new Address
            {
                FirstName = firstName,
                LastName = lastName,
                Road = road,
                ZipCode = zipCode,
                Town = town
            });
        }

        //Methode zum Suchen nach Personen
        public List<Address> SearchAfter(string fullName) =>
            this.Where(q => q.FullName.Contains(fullName, StringComparison.OrdinalIgnoreCase)).ToList();
            //this: AddressBook erbt von List<Address>
            //Where(q => <true/false>): Linq-Methode zum Filtern von Collections, Lambda-Expression als Parameter
            //                          q repräsentiert Element in Collection, filtert alle Element für die der Ausdruck nach => true ist heraus
            //ToList(): IEnumerable<Address>, das von Where(q => ...) zurückgegeben wird in List<Address> umgewandelt

        //ToString-Methode von Object-Basisklasse überschrieben für Ausgabe aller Adressen,
        //wird automatisch aufgerufen, wenn man z.B. Console.Write() ein Object übergibt
        public override string ToString() => 
            string.Join($"{Environment.NewLine}-------------------------------------{Environment.NewLine}", this);
            //string.Join fügt Collection (hier this weil AddressBook von List<Address> erbt) zu string zusammen
            //Elemente werden mit angegebenem Separator (1. Parameter) unterteilt
            //string.Join ruft wiederum ToString() für einzelnen Adress-Objekte auf

        //Methode um sicher int-Input zu erhalten
        private static int ReadIntFromConsole()
        {
            int retValue;
            string input;
            do
            {
                input = Console.ReadLine();
            }
            while (!int.TryParse(input, out retValue) && retValue > 0);

            return retValue;
        }
    }
}
