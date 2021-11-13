using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3
{
    class Adressdaten      //Erstellen einer Klasse Adressdaten 
    {
        //Alle Objekte der Klasse Adressdaten sollen die Attribute Vorname, Nachname, Straße, Postleitzahl und Ort als string enthalten
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Straße { get; set; }
        public string Postleitzahl { get; set; }
        public string Ort { get; set; }
        public override string ToString()       //Durch die override Methode wird ein string in einem definierten Ausgabeformat aus allen Attributen zusammengestellt und zurückgegeben
        {
            return Vorname + " " + Nachname + "/" + Straße + "//" + Postleitzahl + " " + Ort;
        }

        //Konstruktor zum einlesen der Daten für das Objekt
        public Adressdaten(string Vorname, string Nachname, string Straße, string Postleitzahl, string Ort)
        {
            this.Vorname = Vorname;     //Da die Inputvariablen der Methode gleich heißen, wei die Attribute des Objekts, müssen zweitere über this."Attribut" aufgerufen werden
            this.Nachname = Nachname;
            this.Straße = Straße;
            this.Postleitzahl = Postleitzahl;
            this.Ort = Ort;
        }



    }    

}
