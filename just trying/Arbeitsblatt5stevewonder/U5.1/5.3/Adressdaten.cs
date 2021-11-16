using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3
{
    public class Adressdaten      //Erstellen einer Klasse Adressdaten 
    {
        //Alle Objekte der Klasse Adressdaten sollen die Attribute Vorname, Nachname, Straße, Postleitzahl und Ort als string enthalten
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Straße { get; set; }
        public string Postleitzahl { get; set; }
        public string Ort { get; set; }

        public override string ToString() =>    //ToString überschrieben, gibt string-Repräsentation des aktuellen Objekts zurück
            //$-Prefix vor string (interpolated string) um in {} Expressions verwenden zu können, außerdem Performancevorteil ggü. Konkatenieren mit +
            $"{Vorname} {Nachname}/{Straße}//{Postleitzahl} {Ort}";

        //Konstruktor zum einlesen der Daten für das Objekt
        public Adressdaten(string vorname, string nachname, string straße, string postleitzahl, string ort)
        {
            Vorname = vorname;     //Da die Inputvariablen der Methode gleich heißen, wei die Attribute des Objekts, müssen zweitere über this."Attribut" aufgerufen werden
            Nachname = nachname;
            Straße = straße;
            Postleitzahl = postleitzahl;
            Ort = ort;
        }
    }    

}
