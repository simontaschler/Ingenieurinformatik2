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
        {
            string[] Zeilen = File.ReadAllLines(@"C:\Users\Steve\Documents\uni\3. Semester\Ing. Inf. II\Angabe\UE6\Fuhrparkdaten.csv");
            List<Fahrzeug> Fahrzeugliste = new List<Fahrzeug>();

            foreach (string Zeile in Zeilen)
            {
                string[] Fahrzeugdatei = Zeile.Split(';');

                int number = int.Parse(Fahrzeugdatei[0]);
                string type = Fahrzeugdatei[1];
                switch (type)
                {
                    case "PKW":
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
                            Console.WriteLine("Fehler in der CSV- Datei!");
                            break;
                        }
                }          
            }
       
            foreach(Fahrzeug n in Fahrzeugliste)
            {
             Console.WriteLine(n);
            }          
            
            
            Console.ReadLine();     
        
        }
    }
}
