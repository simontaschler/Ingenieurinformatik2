using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3
{
    class Adressbuch //Klasse Adressbuch erstellen
    {
        public List<Adressdaten> AdressdatenListe = new List<Adressdaten>(); //Die einzige Eigenschaft des Objekts ist eine Liste in der alle Ydressdaten Objekte gespeichert werden sollten

        public void AdressDatenEinlesen() //Methode zum Einlesen der Adressdaten über ie Konsole
        {
            Console.Clear();        //Über console.clear(); wir das Konsolenfesnster bereinigt, um dem user immer nur die aktuelle Eingabeaufforderung zu präsentieren
            Console.WriteLine("Bestätigen Sie jede Eingabe mit der Enter Taste!\nGeben Sie den Vornamen ein!");
            string VNinput = Console.ReadLine();        //Zum speichern der einzelnen Eingaben werden string Varaibalen erstellt
            Console.Clear();
            Console.WriteLine("Geben Sie den Nachnamen ein!");
            string NMinput = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Geben Sie die Straße inkl. Hausnummer/Stock/Tür ein!");
            string Straßeinput = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Geben Sie die Postleitzahl ein");
            string PLZinput = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Geben Sie den Ort ein!");
            string Ortinput = Console.ReadLine();
            Console.WriteLine("Bestätigen Sie mit Enter!");

            //Anschließend wird über den Konstruktor der Klasse Adressdaten ein Objekt mit jenen gerade eingelesen string Variablen erstellt
            AdressdatenListe.Add(new Adressdaten(VNinput, NMinput, Straßeinput, PLZinput, Ortinput));

            Console.Clear();

        }
        public void Ausgabe()       //Methode zur Ausgabe aller Adressdaten
        {
            foreach (var Daten in AdressdatenListe)     //foreach Schleife zur Ausgabe aller Attribute der Objekte welche in der Adressdatenliste gespeichert wurden
            {

                Console.WriteLine(Daten);
            }
        }
        public void Suche()     //Methode um eine zu einem eingegeben Nachnamen passende Adresse auszugeben
        {
            Console.Write("Geben Sie den Nachnamen der gesuchten Person ein!\n");
            string searchfor = Console.ReadLine();      //Der eingegeben Nachname wird im string searchfor gespeichert
            foreach (Adressdaten i in AdressdatenListe)     //Anschließend wird der eingegebene Nachname mit allen Nachname Attributen der Objekte in der  Adressdatenliste abgegglichen
                if (searchfor == i.Nachname)        //Wenn ein passender Nachname gefunden wird, werden sämtliche Informationen zu dieser Person in Zeile 53 über die Konsole ausgegeben
                {
                    Console.WriteLine(i.Vorname + ": " + i.Straße + "//" + i.Postleitzahl + " " + i.Ort);
                }
        }
    }
}
