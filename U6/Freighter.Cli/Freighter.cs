using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freighter.Cli
{
    internal class Freighter
    {
        private Container[] Containers;
        private static int nextIndex = 0;

        //readonly Feldern können nur im Konstruktor oder bei der Deklaration Werte zugewiesen werden
        private readonly string Captain;
        private readonly string Destination;
        private readonly double MaxLoadingWeight;
        private readonly string Name;
        private readonly string Start;
        private readonly double Weight;

        //Property mit Expression-Body: im Hintergrund Methode get_IsSpace() die wert des angegebenen Ausdrucks zurückgibt, Syntax bei Aufruf wie Feldzugriff
        internal bool IsSpace =>
            //Where(q => <true/false>): Linq-Methode zum Filtern von Collections, Lambda-Expression als Parameter
            //                          q repräsentiert Element in Collection, filtert alle Element für die der Ausdruck nach => true ist heraus
            //Sum(q => <numeric Type>): Linq-Methode zum Aufsummieren von Ausdrücken abhängig von Elementen einer Collection, Lambda-Expression als Parameter
            //                          q repräsentiert Element in Collection, summiert alle Ergebnisse für die Ausdrücke nach => auf (Ergebnisse müssen numerische sein)
            Containers.Where(q => q != null).Sum(q => q.Weight) < MaxLoadingWeight - .3; //-0.3 für Grenzbereich durch Annahme, dass Container mindestens 300 kg wiegen

        internal Freighter(string captain, string name, string start, string destination, double weight) 
        {
            Captain = captain;
            Name = name;
            Start = start;
            Destination = destination;
            Weight = weight;
            MaxLoadingWeight = 500;         //Maximale Zuladung standardmäßig auf 500t
            Containers = new Container[4];  //Array mit standardmäßig 4 Feldern, kann später dynamisch vergrößert werden
        }

        //Summe der Container + Eigengewicht des Frachtschiffs
        internal double CalculateWeight() =>
            //Where(q => <true/false>): Linq-Methode zum Filtern von Collections, Lambda-Expression als Parameter
            //                          q repräsentiert Element in Collection, filtert alle Element für die der Ausdruck nach => true ist heraus
            //Sum(q => <numeric Type>): Linq-Methode zum Aufsummieren von Ausdrücken abhängig von Elementen einer Collection, Lambda-Expression als Parameter
            //                          q repräsentiert Element in Collection, summiert alle Ergebnisse für die Ausdrücke nach => auf (Ergebnisse müssen numerische sein)
            Containers.Where(q => q != null).Sum(q => q.Weight) + Weight;

        //Methode zum Hinzufügen von Containern
        internal void AddContainer(Container container) 
        {
            if (container == null)
                return;

            //Wenn aktuelle Zuladung + Masse des neuen Containers Maximalladung überschreitet wird entsprechende Ausgabe gemacht und returned
            if (Containers.Where(q => q != null).Sum(q => q.Weight) + container.Weight > MaxLoadingWeight)
            //Where(q => <true/false>): Linq-Methode zum Filtern von Collections, Lambda-Expression als Parameter
            //                          q repräsentiert Element in Collection, filtert alle Element für die der Ausdruck nach => true ist heraus
            //Sum(q => <numeric Type>): Linq-Methode zum Aufsummieren von Ausdrücken abhängig von Elementen einer Collection, Lambda-Expression als Parameter
            //                          q repräsentiert Element in Collection, summiert alle Ergebnisse für die Ausdrücke nach => auf (Ergebnisse müssen numerische sein)
            {
                Console.WriteLine("Frachtschiff bereits voll beladen.");
                return;
            }
            
            //Wenn Array für Container voll ist, aber Maximale Zuladung noch nicht überschritten, wird Array um 2 Felder vergrößert
            if (nextIndex >= Containers.Length)
                Array.Resize<Container>(ref Containers, Containers.Length + 2); //erstellt neues Array an selber Speicherreferenz mit angegebener Größe und übernimmt Elemente des zu resizenden Arrays

            Containers[nextIndex] = container;
            nextIndex++;
        }

        //Methode zur Ausgabe, Console.WriteLine(object? value) ruft für value intern ToString() auf
        internal void WriteInfo() =>
            Console.WriteLine(this);

        //ToString-Methode von Object-Basisklasse überschrieben
        //wird automatisch aufgerufen, wenn man z.B. Console.Write() ein Object übergibt
        public override string ToString() =>
            //@-Prefix vor string (verbatim string) für Multiline-Strings (anderes Escape-Pattern)
            //$-Prefix vor string (interpolated string) um in {} Expressions verwenden zu können, außerdem Performancevorteil ggü. Konkatenieren mit +
            //string.Join: fügt Collection zu einem string zusammen
            //             lemente werden mit angegebenem Separator (1. Parameter) unterteilt
            //             ruft für jedes einzelnen Element der Collection ToString() auf
            $@"-----------------------------Frachtschiff {Name}-----------------------------
Kapitän: {Captain}
Maximale Zuladung: {MaxLoadingWeight} t
Leergewicht: {Weight} t
Gesamtgewicht: {CalculateWeight()} t
fährt von {Start} nach {Destination}
-----------------------------Ladung-----------------------------
{string.Join(Environment.NewLine, Containers as object[])}";
    }
}
