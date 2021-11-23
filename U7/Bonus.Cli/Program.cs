using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bonus.Cli
{
    internal class Bonus 
    {
        //MSBuild erstellt bei Auto-Properties automatisch im Hintergrund Getter- und Setter-Methoden
        //z.B. internal string get_Name() bzw. internal void set_Name(string value)
        //wenn diese Methoden nicht überschrieben werden, wird auch privates Feld angelegt, das den Wert speichert, Zugriff erfolgt aber immer über Property
        internal string Name { get; set; }
        internal string Date { get; set; }
        internal double XMasBonus { get; set; }
        internal bool Disburse { get; set; }
        internal double Performance { get; set; }

        //ToString-Methode von Object-Basisklasse überschrieben
        //wird automatisch aufgerufen, wenn man z.B. Console.Write() ein Object übergibt
        public override string ToString() =>
            //$-Prefix vor string (interpolated string) um in {} Expressions verwenden zu können, außerdem Performancevorteil ggü. Konkatenieren mit +
            $"{Name,-30}{XMasBonus,-4}";
    }

    internal class Program
    {
        internal static void Main(string[] args)
        {
            var resourceName = "Bonus.Cli.Mitarbeiterboni.csv"; //Bezeichner der EmbeddedResource (<Default Namespace>.<Filename>)
            var lines = GetEmbeddedResourceLines(resourceName).Skip(1); //Zeile mit Überschriften ignorieren
            var boni = new List<Bonus>();
            var numErrors = 0;
            var lineIndex = 0;

            foreach (var line in lines) 
            {
                try 
                {
                    var fields = line.Split(';');
                    boni.Add(new Bonus                       //neues Bonus Objekt erzeugen und Liste hinzufügen
                    {
                        Name = fields[0],
                        Date = fields[1],
                        XMasBonus = double.Parse(fields[2]),
                        Disburse = bool.Parse(fields[3]),
                        Performance = double.Parse(fields[4]) / 100
                    });
                    Console.WriteLine($"Zeile {lineIndex} erfolgreich eingelesen.");
                }
                catch (Exception) //fängt jede mögliche Exception ab
                {
                    numErrors++;
                    Console.WriteLine($"Zeile {lineIndex} fehlerhaft.");
                }
                finally //wird immer ausgeführt, unabhängig davon, ob Exception auftritt
                {
                    lineIndex++;
                    //bei jedem Schleifendurchlauf ausgeben???
                    //Console.WriteLine("Vielen Dank für Ihr Interesse an Inhenieurinformatik II!")
                }
            }
            //$-Prefix vor string (interpolated string) um in {} Expressions verwenden zu können, außerdem Performancevorteil ggü. Konkatenieren mit +
            Console.WriteLine($"Fehler in {numErrors} Zeilen.");
            Console.WriteLine();
            Console.WriteLine($"{"Name",-30}Bonus");

            //string.Join: fügt Collection zu einem string zusammen
            //             Elemente werden mit angegebenem Separator (1. Parameter) unterteilt
            //             ruft für jedes einzelnen Element der Collection ToString() auf
            //OrderBy(q => ...): Linq-Methode zum Sortieren von Collections, Lambda-Expression als Parameter
            //                   q repräsentiert Element in Collection, sortiert Collection basierend auf dem von q abhängigen Ausdruck nach =>
            //					 gibt Collection von Typ IOrderedEnumerable zurück
            Console.WriteLine(string.Join(Environment.NewLine, boni.OrderBy(q => q.Name)));
            Console.WriteLine();
            //Sum(q => <numeric Type>): Linq-Methode zum Aufsummieren von Ausdrücken abhängig von Elementen einer Collection, Lambda-Expression als Parameter
            //                          q repräsentiert Element in Collection, summiert alle Ergebnisse für die Ausdrücke nach => auf (Ergebnisse müssen numerische sein)
            //$-Prefix vor string (interpolated string) um in {} Expressions verwenden zu können, außerdem Performancevorteil ggü. Konkatenieren mit +
            Console.WriteLine($"Summe Boni: {boni.Sum(q => q.XMasBonus)}");

            Console.ReadLine();
        }

        //ersetzt File.ReadAllLines
        //
        //Methode um auf CSV-File als EmbeddedResource anstatt über FileSystem zuzugreifen
        //Durch Einbindung als EmbeddedResource ist CSV-File nicht mehr von Dateipfad abhängig sondern in Projekt integriert
        //gibt CSV als Menge von Zeilen zurück
        internal static IEnumerable<string> GetEmbeddedResourceLines(string resourceName)
        {
            var assembly = Assembly.GetExecutingAssembly();                         //laufende Assembly über Reflection holen
            using (var stream = assembly.GetManifestResourceStream(resourceName))   //über Assembly Stream zur EmbeddedResource öffnen
            using (var reader = new StreamReader(stream))                           //StreamReader für Stream initialisieren
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    //yield return:
                    //bei Methoden mit return type IEnumerable<T> kann yield return verwendet werden, um Stück für Stück eine Collection zusammenzubauen
                    //yield return x, wobei x vom Typ T, fügt also x einer Collection im Hintergrund hinzu, die erst als ganze zurückgegeben wird, wenn Methode vollständig durchgelaufen ist
                    yield return line;
                }
            }
        }
    }
}
