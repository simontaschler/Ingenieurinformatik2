using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinks.Cli
{
    internal class Drink
    {
        private static int nextID = 1; //statisches Feld zum Speichern der ID für das nächste Object

        internal int ID { get; } //readonly Property, nur Get-Methode, kann nur Wert im Ctor zugewiesen werden
        internal string Name { get; set; } //Properties, d.h. es werden im Hintergrund automatisch Get- & Set-Methoden generiert
        internal float Alcohol { get; set; }
        internal bool Mixable { get; set; }

        //Ctor setzt ID, keine Parameter, weil diese über Properties gesetzt werden
        public Drink()
        {
            ID = nextID;
            nextID++;
        }

        //ToString-Methode von Object-Basisklasse überschrieben für Ausgabe der Tabellenzeile
        public override string ToString() =>
            new StringBuilder($"  {ID}".PadRight(12))   //StringBuilder: Performance optimiertes Zusammenbauen von strings
            .Append(Name.PadRight(12))                  //Append: fügt neues Stück zum zu buildenden Sting hinzu
            .Append($"{Alcohol}".PadRight(12))          //PadRight: Füllt nach rechts mit Leerzeichen bis Länge x auf
            .Append($"{Mixable}".PadRight(12))
            .ToString();
    }
}
