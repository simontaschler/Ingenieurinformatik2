using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addresses.Cli
{
    internal class Address
    {
        //MSBuild erstellt bei Auto-Properties automatisch im Hintergrund Getter- und Setter-Methoden
        //z.B. internal string get_FirstName() bzw. internal void set_Name(string value)
        //wenn diese Methoden nicht überschrieben werden, wird auch privates Feld angelegt, das den Wert speichert
        internal string FirstName { get; set; }
        internal string LastName { get; set; }
        internal string Road { get; set; }
        internal int ZipCode { get; set; }
        internal string Town { get; set; }

        //Property mit Expression-Body: im Hintergrund Methode get_FullName() die Kombination aus Vor- & Nachname zurückgibt, Syntax bei Aufruf wie Feldzugriff
        internal string FullName => 
            $"{FirstName} {LastName}";

        //ToString-Methode von Object-Basisklasse überschrieben für Ausgabe aller Adressen,
        //wird automatisch aufgerufen, wenn man z.B. Console.Write() ein Object übergibt
        public override string ToString() =>
            $@"{FirstName} {LastName}:
    {Road}, {ZipCode} {Town}";
    }
}
