using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TU_SkiSim
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static List<Skier> GetTicketList()
        {
            List<Skier> skierList= new List<Skier>();
            string[] Zeilen = File.ReadAllLines(@"C: \Users\Steve\Documents\uni\3.Semester\Ing.Inf.II\Arbeitsverzeichnis\U1\U1\Basisprojekte Stefan\TU - SkiSim\Angabe\Ticketverkaeufe.CSV)");
            foreach (string n in Zeilen)
            {
                string[] skiffahrerArray = n.Split(';');
                string type = skiffahrerArray[2];

                switch (type)
                {
                    case ("1"):
                        skierList.Add(new Beginner(int.Parse(skiffahrerArray[0]), int.Parse(skiffahrerArray[1])));
                        break;
                    case ("2"):
                        skierList.Add(new Advanced(int.Parse(skiffahrerArray[0]), int.Parse(skiffahrerArray[1])));
                        break;
                    case ("3"):
                        skierList.Add(new Expert(int.Parse(skiffahrerArray[0]), int.Parse(skiffahrerArray[1])));
                        break;
                    default:
                        Console.WriteLine("Error 69! Unbekanntes Skilllevel in der Liste");
                        break;
                }
            }        
            return skierList;
        }     
    }
}
