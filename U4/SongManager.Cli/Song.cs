using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongManager.Cli
{
    internal class Song
    {
        internal string Name { get; set; }  //Properties, d.h. es werden im Hintergrund automatisch Get- & Set-Methoden generiert
        internal string Artist { get; set; }
        internal TimeSpan Length { get; set; } //System.TimeSpan: Datentyp für Zeitintervalle

        internal Song(string name, string artist, TimeSpan length)
        {
            Name = name;
            Artist = artist;
            Length = length;
        }

        //ToString-Methode von Object-Basisklasse überschrieben für Ausgabe der Eigenschaften
        public override string ToString() => 
            $"Name:   {Name}\nArtist: {Artist}\nLength: {Length:%m\\:ss}\n";    //:%m\\:ss Formatierung TimeSpan
                                                                                //$ vor String ist interpolated string, d.h. in { } können Ausdrücke & Varaiblen verwendet werden
    }
}
