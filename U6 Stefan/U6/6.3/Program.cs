using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3
{
    class Program
    {
        static void Main(string[] args)
        {           //Speichrn der eingelesenen Daten aus der CSV Datei in ein string Array mit dem Namen Zeilen
                    //Jede Zeile der Datei ist nun eín Ellement im Array
            string[] Zeilen = File.ReadAllLines(@"C:\Users\Steve\Documents\uni\3. Semester\Ing. Inf. II\Angabe\UE6\Fuhrparkdaten.csv");
            List<Fahrzeug> Fahrzeugliste = new List<Fahrzeug>();        //Anlegen einer Liste für den objekttyp Fahrzeug in dem später alle Fahrzeuge gespeichert werden sollen

            foreach (string Zeile in Zeilen)            //Für jedes Element im Array werden nun die Eigenschaften (welche in der CSV DAtei durch ";" getrennt sind) einzeln in ein neues Array gespeichert 
            {
                string[] Fahrzeugdatei = Zeile.Split(';');      //Splitten und speichern

              
                string type = Fahrzeugdatei[1];     //Der Typ des Fahrzeugs wird aus den jeweiligen Arrays an 2.er Stelle (1) ausgelesen
                switch (type)                       //Je nach Typ muss ein anderes Objekt erstellt werden
                {
                    case "PKW":                     //Im Fall PKW wird ein Obejtk vom Typ PKW erstellt. Sämtliche Werte für den Konstruktor werden aus dem Array ausgelesen und anschließend ausgegeben
                        {
                            Fahrzeugliste.Add(new PKW(Fahrzeugdatei[0],int.Parse(Fahrzeugdatei[3]), int.Parse(Fahrzeugdatei[4]), int.Parse(Fahrzeugdatei[2])));
                            break;
                        }
                    case "LKW":
                        {
                            Fahrzeugliste.Add(new LKW(Fahrzeugdatei[0], int.Parse(Fahrzeugdatei[3]), int.Parse(Fahrzeugdatei[4]), int.Parse(Fahrzeugdatei[2])));
                            break;
                        }

                    case "KB":
                        {
                            Fahrzeugliste.Add(new Keintransporter(Fahrzeugdatei[0], int.Parse(Fahrzeugdatei[3]), int.Parse(Fahrzeugdatei[4]), int.Parse(Fahrzeugdatei[2])));
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Fehler in der CSV- Datei!");     //Falls ein unbekannter Typ eingelesen wurde, gibt das Programm eine Fehlermeldung aus
                            break;
                        }
                }          
            }
       
            foreach(Fahrzeug n in Fahrzeugliste)
            {
             Console.WriteLine(n);      //Ausgabe aller Fahrzeuge in der Fahrzeugliste durch aufrufen der jeweiligen toString Methode
            }          
            
            
            Console.ReadLine();     
        
        }
    }
}
