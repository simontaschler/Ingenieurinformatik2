using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Cli
{
    //IComparable<T>:
    //Generische Variante des IComparable Interfaces, CompareTo Methode erwartet Parameter vom Typ T anstatt object
    //Speziefischer Overload von CompareTo für Vergleiche mit bestimmten Datentyp, ohne, wie bei nicht-generischem IComparable, 
    //mit Reflection (schlechte Performance) Objekt auf Datentyp überprüfen zu müssen
    internal class Phone : IComparable<Phone>
    {
        //MSBuild erstellt bei Auto-Properties automatisch im Hintergrund Getter- und Setter-Methoden
        //z.B. internal string get_Name() bzw. internal void set_Name(string value)
        //wenn diese Methoden nicht überschrieben werden, wird auch privates Feld angelegt, das den Wert speichert
        internal string Name { get; set; }
        internal float Price { get; set; }

        //CompareTo(T other):
        //CompareTo-Methode des IComparable<T> Interfaces, erwartet Parameter des Typs ToList
        //gibt int > 0 zurück, wenn aktuelle Instanz als größer als Parameter zu betrachten ist
        //gibt int < 0 zurück, wenn aktuelle Instanz als kleiner als Parameter zu betrachten ist
        //gibt 0 zurück, wenn aktuelle Instanz als gleich dem Parameter zu betrachten ist
        public int CompareTo(Phone other) =>
            //Conditional Expression (kurzschreibweise für ifs): <logische Bedingung> ? <Wert wenn true> : <Wert wenn false>
            //Ausdruck?.Aufruf: integrierter null-Check, wenn Ausdruck vor ?. null ist, wird gesamter Ausdruck mit nachfolgenden Aufrufen als null angenommen
            //					zum Verhindern von Aufrufen über null und daraus folgenden System.NullReferenceExceptions
            Price != other?.Price               //Wenn Preise ungleich sind, werden diese für den Vergleich der Handys verwendet, ansonsten die Namen
                ? Price.CompareTo(other?.Price)
                : Name.CompareTo(other?.Name);

        public override string ToString() =>
            //$-Prefix vor string (interpolated string) um in {} Expressions verwenden zu können, außerdem Performancevorteil ggü.Konkatenieren mit +
            //<float>,10:C2: auf string mit Länge 10 mit Whitespace links auffüllen, als Währung mit 2 Nachkommastellen formatieren
            $"{Name}: {Price,10:C2}";
    }
}
