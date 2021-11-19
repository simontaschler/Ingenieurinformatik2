using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3
{
    public class Adressbuch //Klasse Adressbuch erstellen
    {
        //MSBuild erstellt bei Auto-Properties automatisch im Hintergrund Getter-Methode
        //z.B. internal string get_Name()
        //wenn diese Methode nicht überschrieben wird, wird auch privates Feld angelegt, das den Wert speichert, Zugriff erfolgt aber immer über Property
        //wenn nur get-Operator angegeben wird, handelt es sich um readonly-Property, d.h. es können nur im Konstruktor oder bei der Deklaration Werte zugewiesen werden
        public List<Adressdaten> AdressdatenListe { get; } = new List<Adressdaten>();

        internal void AdressDatenEinlesen() //Methode zum Einlesen der Adressdaten über die Konsole
        {
            Console.Clear();        //Über console.clear(); wird das Konsolenfenster bereinigt, um dem user immer nur die aktuelle Eingabeaufforderung zu präsentieren
            Console.WriteLine("Bestätigen Sie jede Eingabe mit der Enter Taste!\nGeben Sie den Vornamen ein!");
            string VNinput = Console.ReadLine().Trim();        //Zum speichern der einzelnen Eingaben werden string Variablen erstellt . Trim entfernt miteingebebne Leerzeichen
            Console.Clear();
            Console.WriteLine("Geben Sie den Nachnamen ein!");
            string NMinput = Console.ReadLine().Trim();
            Console.Clear();
            Console.WriteLine("Geben Sie die Straße inkl. Hausnummer/Stock/Tür ein!");
            string Straßeinput = Console.ReadLine().Trim();
            Console.Clear();
            Console.WriteLine("Geben Sie die Postleitzahl ein");
            string PLZinput = Console.ReadLine().Trim();
            Console.Clear();
            Console.WriteLine("Geben Sie den Ort ein!");
            string Ortinput = Console.ReadLine().Trim();
            Console.WriteLine("Bestätigen Sie mit Enter!");

            //Anschließend wird über den Konstruktor der Klasse Adressdaten ein Objekt mit jenen gerade eingelesen string Variablen erstellt
            AdressdatenListe.Add(new Adressdaten(VNinput, NMinput, Straßeinput, PLZinput, Ortinput));

            Console.Clear();

        }

        internal void Ausgabe()       //Methode zur Ausgabe aller Adressdaten
        {
            foreach (var Daten in AdressdatenListe)     //foreach Schleife zur Ausgabe aller Attribute der Objekte welche in der Adressdatenliste gespeichert wurden
            {
                Console.WriteLine(Daten);
            }
            Console.ReadLine();
        }
        
        internal void Suche()     //Methode um eine zu einem eingegeben Nachnamen passende Adresse auszugeben
        {
            Console.Write("Geben Sie den Nachnamen der gesuchten Person ein!\n");
            string searchfor = Console.ReadLine();      //Der eingegeben Nachname wird im string searchfor gespeichert
            foreach (Adressdaten i in AdressdatenListe)     //Anschließend wird der eingegebene Nachname mit allen Nachname Attributen der Objekte in der  Adressdatenliste abgegglichen
            {
                if (searchfor == i.Nachname)
                {                                           //Wenn ein passender Nachname gefunden wird, werden sämtliche Informationen zu dieser Person in Zeile 53 über die Konsole ausgegeben
                    Console.WriteLine(i);
                    Console.ReadLine();
                }
            }
        }
    }
}
