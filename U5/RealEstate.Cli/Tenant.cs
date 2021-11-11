using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Cli
{
    internal class Tenant
    {
        //MSBuild erstellt bei Auto-Properties automatisch im Hintergrund Getter- und Setter-Methoden
        //z.B. internal string get_Name() bzw. internal void set_Name(string value)
        //wenn diese Methoden nicht überschrieben werden, wird auch privates Feld angelegt, das den Wert speichert
        internal string Name { get; set; }
        internal int Age { get; set; }
        internal float RentToPay { get; set; } //keine eigene Methode setMiete, da Methode durch Auto-Property generiert
        
        //ToString-Methode von Object-Basisklasse überschrieben
        //wird automatisch aufgerufen, wenn man z.B. Console.Write() ein Object übergibt
        public override string ToString() =>
            //$-Prefix um in {} Expressions verwenden zu können, außerdem Performancevorteil ggü. Konkatenieren mit +
            $"{Name}, {Age}: {RentToPay:C2}"; //<float>:C2: als Währung mit 2 Nachkommastellen formatieren
    }
}
