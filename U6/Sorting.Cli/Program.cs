using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorting.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var numbers = new List<int> { 1, 2, 3, 4, 5 };

            //string.Join fügt Collection zu einem string zusammen
            //Elemente werden mit angegebenem Separator (1. Parameter) unterteilt
            //ruft für jedes einzelnen Element der Collection ToString() auf
            Console.WriteLine(string.Join(", ", numbers));
            numbers.Reverse();                                  //Sequenz der Liste invertieren
            Console.WriteLine(string.Join(", ", numbers));

            Console.WriteLine();
            Console.WriteLine();

            var phones = new List<Phone>
            {
                new Phone { Name="iPhone", Price=1000F },
                new Phone { Name="Samsung", Price=1000F },
                new Phone { Name="Huawei", Price=400F }
            };

            //string.Join fügt Collection zu einem string zusammen
            //Elemente werden mit angegebenem Separator (1. Parameter) unterteilt
            //ruft für jedes einzelnen Element der Collection ToString() auf
            Console.WriteLine(string.Join(Environment.NewLine, phones));
            phones.Sort();                                                  //Liste sortieren
            Console.WriteLine();
            Console.WriteLine(string.Join(Environment.NewLine, phones));

            //Alternativ: Linq (Language integrated queries)
            //OrderBy(q => ...): Linq-Methode zum Sortieren von Collections, Lambda-Expression als Parameter
            //                   q repräsentiert Element in Collection, sortiert Collection basierend auf dem von q abhängigen Ausdruck nach =>
            //					 gibt Collection von Typ IOrderedEnumerable zurück
            //ThenBy(q => ...): Linq-Methode um IOrderedEnumerables mit weiteren Sortierkriterien zu versehen, Lambda-Expression als Parameter
            //                  q repräsentiert Element in Collection, fügt neues Sortierkriterium basierend auf dem von q abhängigen Ausdruck nach =>
            //					gibt Collection von Typ IOrderedEnumerable zurück
            //ToList(): IEnumerable<T> wird in List<T> umgewandelt
            //
            //funktioniert ohne IComparable, IComparer o.ä., man erhält sortierte Collection als eigenes Objekt => alte Collection mit alter Reihenfolge bleibt erhalten
            //verwendet anderen Sortieralgorithmus als List<T>.Sort() bzw. Array.Sort()
            //verwendet stable Quicksort ggü. unstable Introsort von Array.Sort() (stable => "gleiche" Elemente behalten gleiche Reihenfolge)
            //gleiche Average-Performance, aber schlechtere Worst-Case-Performance ggü. Array.Sort()
            
            //var sortedList = phones.OrderBy(q => q.Price).ThenBy(q => q.Name).ToList();
        }
    }
}
