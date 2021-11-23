using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freighter.Cli
{
    internal class Container
    {
        private static int nextID = 1;

        //readonly Feldern können nur im Konstruktor oder bei der Deklaration Werte zugewiesen werden
        protected readonly int ID;  //ID als readonly um in ToString von Derivaten verwendet werden zu können
        protected string Content;

        //MSBuild erstellt bei Auto-Properties automatisch im Hintergrund Getter- und Setter-Methoden
        //z.B. internal double get_Weight() bzw. private void set_Weight(double value)
        //wenn diese Methoden nicht überschrieben werden, wird auch privates Feld angelegt, das den Wert speichert, Zugriff erfolgt aber immer über Property
        internal double Weight { get; private set; }
        //Property mit Expression-Body: im Hintergrund Methode internal double get_Temperature() die wert des angegebenen Ausdrucks zurückgibt, Syntax bei Aufruf wie Feldzugriff
        //virtual: Property kann überschrieben werden
        internal virtual double Temperature => 20;

        internal Container(string content, double weight)
        {
            Content = content;
            Weight = weight;
            ID = nextID;
            nextID++;
        }

        //ToString-Methode von Object-Basisklasse überschrieben
        //wird automatisch aufgerufen, wenn man z.B. Console.Write() ein Object übergibt
        public override string ToString() =>
            //$-Prefix vor string (interpolated string) um in {} Expressions verwenden zu können, außerdem Performancevorteil ggü. Konkatenieren mit +
            //<double>:N2: double Wert wird zu string mit 2 Nachkommastellen formatiert
            $"Container {ID}: {Content}, {Weight} t, {Temperature:N2} °C";
    }
}
