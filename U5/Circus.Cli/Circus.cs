using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circus.Cli
{
    internal class Circus
    {
        private Animal[] _animals;
        private int nextIndex = 0; //Feld für den nächsten Index im Array an Tieren

        //MSBuild erstellt bei Auto-Properties automatisch im Hintergrund Getter- und Setter-Methoden
        //z.B. internal string get_Name() bzw. internal void set_Name(string value)
        //wenn diese Methoden nicht überschrieben werden, wird auch privates Feld angelegt, das den Wert speichert
        internal Trainer Trainer { get; set; }
        internal string Name { get; set; }

        internal Circus(int numAnimals) =>
            _animals = new Animal[numAnimals];

        //Methode zum Hinzufügen von Tieren
        internal void AddAnimal(Animal animal) 
        {
            if (animal == null)
                return;

            if (nextIndex >= _animals.Length) //wenn kein Platz mehr wird entsprechende Ausgabe gemacht und returned
            {
                Console.WriteLine("Kein Platz mehr.");
                return;
            }

            _animals[nextIndex] = animal;   //Tier wird bei aktuellem Index eingefügt
            nextIndex++;                    //aktueller Index um 1 erhöht
        }

    //Kürzere Alternative zu Ausgabe mit foreach:

        //ToString-Methode von Object-Basisklasse überschrieben
        //wird automatisch aufgerufen, wenn man z.B. Console.Write() ein Object übergibt
        public override string ToString() =>
            //@-Prefix vor string für Multiline-Strings (anderes Escape-Pattern)
            //$-Prefix um in {} Expressions verwenden zu können, außerdem Performancevorteil ggü. Konkatenieren mit +
            $@"-------------{Name}-------------
Trainer: {Trainer}
Tiere:
{string.Join(Environment.NewLine, _animals as object[])}";
        //string.Join fügt Collection zu einem string zusammen
        //Elemente werden mit angegebenem Separator (1. Parameter) unterteilt
        //ruft für jedes einzelnen Element der Collection ToString() auf


    //ToString Methode mit foreach-Schleife und Stringbuilder:

        //public override string ToString()
        //{
        //    var sb = new StringBuilder().AppendLine($"-------------{Name}-------------"); //StringBuilder: Performance optimiertes Zusammenbauen von strings
        //    sb.AppendLine($"Trainer: {Trainer}").AppendLine("Tiere:");                    //AppendLine: fügt neues Stück plus LineBreak am Ende zum zu buildenden Sting hinzu
        //    foreach (var animal in _animals)
        //        sb.AppendLine(animal.ToString());
        //    return sb.ToString();
        //}
    }
}
