using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Vehicles.Cli
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            try     //try-catch-clause um mögliche Fehler beim Parsen der CSV abzufangen
                    //in diesem Fall nicht in Methode InitializeVehicleFleet weil yield return innerhalb von try-catch nicht zulässig ist
            {
                var vehicles = InitializeVehicleFleet().ToList();//ToList(): IEnumerable<T> wird in List<T> umgewandelt
                vehicles.ForEach(q => Console.WriteLine(q));    //ForEach(q => ...): Linq-Methode als Kurzschreibweise von foreach-Schleifen, Lambda-Expression als Parameter
                                                                //                   q repräsentiert Element in Collection, führt Aktion nach => für alle Elemente in Collection aus
            }
            catch (FormatException) //FormatException wird von int.Parse geworfen wenn Input nicht konvertierbar ist
            {
                Console.WriteLine("Fehler beim Einlesen der Fuhrparkdaten.");
            }
        }

        //Erstellt Fahrzeugflotte basierend auf Inhalt des CSVs
        internal static IEnumerable<Vehicle> InitializeVehicleFleet() 
        {
            var resourceName = "Vehicles.Cli.Fuhrparkdaten.csv"; //Bezeichner der EmbeddedResource (<Default Namespace>.<Filename>)
            var lines = GetEmbeddedResourceLines(resourceName);

            foreach (var line in lines) //Zeilen der CSV werden durchiteriert und für jede Zeile das entsprechende Objekt erzeugt
            {
                var fields = line.Trim().Split(';'); //unterteilt string in Array anhand von gegebenem Separator
                switch (fields[1])
                {
                                //yield return:
                                //bei Methoden mit return type IEnumerable<T> kann yield return verwendet werden, um Stück für Stück eine Collection zusammenzubauen
                                //yield return x, wobei x vom Typ T, fügt also x einer Collection im Hintergrund hinzu, die erst als ganze zurückgegeben wird, wenn Methode vollständig durchgelaufen ist
                    case "PKW": yield return new Car(fields[0], int.Parse(fields[3]), int.Parse(fields[4]), int.Parse(fields[2])); break;
                    case "LKW": yield return new Truck(fields[0], int.Parse(fields[3]), int.Parse(fields[4]), int.Parse(fields[2])); break;
                    case "KB": yield return new Transporter(fields[0], int.Parse(fields[3]), int.Parse(fields[4]), int.Parse(fields[2])); break;
                };
            }
        }

        //Methode um auf CSV-File als EmbeddedResource anstatt über FileSystem zuzugreifen
        //Durch Einbindung als EmbeddedResource ist CSV-File nicht mehr von Dateipfad abhängig sondern in Projekt integriert
        //gibt CSV als Menge von Zeilen zurück
        //ersetzt File.ReadAllLines
        internal static IEnumerable<string> GetEmbeddedResourceLines(string resourceName) 
        {
            var assembly = Assembly.GetExecutingAssembly();                         //laufende Assembly über Reflection holen
            using var stream = assembly.GetManifestResourceStream(resourceName);    //über Assembly Stream zur EmbeddedResource öffnen
            using var reader = new StreamReader(stream);                            //StreamReader für Stream initialisieren
            
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
