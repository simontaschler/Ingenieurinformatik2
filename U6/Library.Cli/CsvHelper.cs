using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Library.Cli
{
    internal static class CsvHelper
    {
        //Erstellt Fahrzeugflotte basierend auf Inhalt des CSVs
        internal static IEnumerable<Media> InitializeMediaInventory()
        {
            var resourceName = "Library.Cli.Medienlisten.csv"; //Bezeichner der EmbeddedResource (<Default Namespace>.<Filename>)
            var lines = GetEmbeddedResourceLines(resourceName);

            foreach (var line in lines) //Zeilen der CSV werden durchiteriert und für jede Zeile das entsprechende Objekt erzeugt
            {
                var fields = line.Trim().Split(';'); //unterteilt string in Array anhand von gegebenem Separator
                switch (fields[0])
                {
                    //yield return:
                    //bei Methoden mit return type IEnumerable<T> kann yield return verwendet werden, um Stück für Stück eine Collection zusammenzubauen
                    //yield return x, wobei x vom Typ T, fügt also x einer Collection im Hintergrund hinzu, die erst als ganze zurückgegeben wird, wenn Methode vollständig durchgelaufen ist
                    case "Buch": yield return new Book(fields[3], fields[2], int.Parse(fields[4]), fields[1], double.Parse(fields[5])); break;
                    case "Zeitschrift": yield return new Magazine(fields[3], fields[2], int.Parse(fields[4]), fields[1], double.Parse(fields[5])); break;
                    case "Multimedia": yield return new MultiMedia(fields[3], fields[2], int.Parse(fields[4]), fields[1], double.Parse(fields[5])); break;
                };
            }
        }

        //Methode um auf CSV-File als EmbeddedResource anstatt über FileSystem zuzugreifen
        //Durch Einbindung als EmbeddedResource ist CSV-File nicht mehr von Dateipfad abhängig sondern in Projekt integriert
        //gibt CSV als Menge von Zeilen zurück
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
