using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U5._1
{
    public class Tier
    {
        //MSBuild erstellt bei Auto-Properties automatisch im Hintergrund Getter-Methode
        //z.B. public string get_Name()
        //wenn diese Methode nicht überschrieben wird, wird auch privates Feld angelegt, das den Wert speichert, Zugriff erfolgt aber immer über Property
        //wenn nur get-Operator angegeben wird, handelt es sich um readonly-Property, d.h. es können nur im Konstruktor Werte zugewiesen werden
        public string Name { get; }
        public string Rasse { get; }

        //Konstruktor zum erstellen eines Tier Objektes
        public Tier(string name, string rasse)
        {
            Name = name;
            Rasse = rasse;
        }

        //Methode zur Ausgabe der Tiernamen und Rassen
        public void Ausgabe() =>
            //$-Prefix vor string (interpolated string) um in {} Expressions verwenden zu können, außerdem Performancevorteil ggü. Konkatenieren mit +
            Console.WriteLine($"                 {Name} {Rasse}");
    }
}
