using System;
using System.Linq;

namespace Library.Cli
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            //CsvHelper: statische Helperklasse fürs Einlesen des CSVs
            //ToList(): IEnumerable<T> wird in List<T> umgewandelt
            var allMedia = CsvHelper.InitializeMediaInventory().ToList();

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //$-Prefix vor string (interpolated string) um in {} Expressions verwenden zu können, außerdem Performancevorteil ggü. Konkatenieren mit +
            //OfType<T>(): Linq-Methode zum Filtern von Collections basierend auf dem Type der Elemente, 
            //			   gibt IEnumerable<T> aller Elemente der Collection, die den Type T haben zurück
            //Sum(q => <numeric Type>): Linq-Methode zum Aufsummieren von Ausdrücken abhängig von Elementen einer Collection, Lambda-Expression als Parameter
            //                          q repräsentiert Element in Collection, summiert alle Ergebnisse für die Ausdrücke nach => auf (Ergebnisse müssen numerische sein)
            //<double>:C2: double Wert als Währung mit 2 Nachkommastellen formatieren
            Console.WriteLine($"Summe aller Bücher: {allMedia.OfType<Book>().Sum(q => q.GetPrice()):C2}");
            Console.WriteLine($"Summe aller Multimedias: {allMedia.OfType<MultiMedia>().Sum(q => q.GetPrice()):C2}");
            Console.WriteLine($"Summe aller Zeitschriften: {allMedia.OfType<Magazine>().Sum(q => q.GetPrice()):C2}");
            Console.WriteLine();

            //string.Join fügt Collection zu einem string zusammen
            //Elemente werden mit angegebenem Separator (1. Parameter) unterteilt
            //ruft für jedes einzelnen Element der Collection ToString() auf
            Console.WriteLine(string.Join(Environment.NewLine, allMedia));
            Console.WriteLine();
            allMedia.Sort();                        //alle Medien sortieren
            Console.WriteLine("Sortierte Liste:");
            Console.WriteLine(string.Join(Environment.NewLine, allMedia));

            //Alternativ: Linq (Language integrated queries)
            //OrderBy(q => ...): Linq-Methode zum Sortieren von Collections, Lambda-Expression als Parameter
            //                   q repräsentiert Element in Collection, sortiert Collection basierend auf dem von q abhängigen Ausdruck nach =>
            //					 gibt Collection von Typ IOrderedEnumerable zurück
            //ToList(): IEnumerable<T> wird in List<T> umgewandelt
            //
            //funktioniert ohne IComparable, IComparer o.ä., man erhält sortierte Collection als eigenes Objekt => alte Collection mit alter Reihenfolge bleibt erhalten
            //verwendet anderen Sortieralgorithmus als List<T>.Sort() bzw. Array.Sort()
            //verwendet stable Quicksort ggü. unstable Introsort von Array.Sort() (stable => "gleiche" Elemente behalten gleiche Reihenfolge)
            //gleiche Average-Performance, aber schlechtere Worst-Case-Performance ggü. Array.Sort()

            //var sortedList = allMedia.OrderBy(q => q.Author).ToList();
        }
    }
}
