using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3
{
    class Adressdaten
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Straße { get; set; }
        public string Postleitzahl { get; set; }
        public string Ort { get; set; }
        public override string ToString()
        {
            return Vorname + " " + Nachname + "/" + Straße + "//" + Postleitzahl + " " + Ort;
        }

        public Adressdaten(string Vorname, string Nachname, string Straße, string Postleitzahl, string Ort)
        {
            this.Vorname = Vorname;
            this.Nachname = Nachname;
            this.Straße = Straße;
            this.Postleitzahl = Postleitzahl;
            this.Ort = Ort;
        }



    }    

}
