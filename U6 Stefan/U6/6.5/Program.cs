using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<Buch> alleBuecher = new List<Buch>();
            List<Zeitschrift> alleZeitschriften = new List<Zeitschrift>();
            List<Multimedia> alleMultimedias = new List<Multimedia>();
            List<Medium> alleMedien = new List<Medium>();

            string[] Zeilen = File.ReadAllLines(@"C:\Users\Steve\Documents\uni\3. Semester\Ing. Inf. II\Angabe\UE6\Medienlisten.csv").Skip(1).ToArray();
            foreach (string n in Zeilen)
            {
                string[] Medienarray = n.Split(';');
                string type = Medienarray[0];

                switch(type)
                {
                    case ("Buch"):
                        alleBuecher.Add(new Buch(Medienarray[3], Medienarray[2], Medienarray[1], int.Parse(Medienarray[4]), double.Parse(Medienarray[5])));                        
                        break;
                    case ("Zeitschrift"):
                        alleZeitschriften.Add(new Zeitschrift(Medienarray[3], Medienarray[2], Medienarray[1], int.Parse(Medienarray[4]), double.Parse(Medienarray[5])));                        
                        break;
                    case ("Multimedia"):
                        alleMultimedias.Add(new Multimedia(Medienarray[3], Medienarray[2], Medienarray[1], int.Parse(Medienarray[4]), double.Parse(Medienarray[5])));
                        break;
                    default:
                        Console.WriteLine("Error 69! Unbekanntes Medium in der Liste");
                        break;                       
                }               
            }
            alleMedien.AddRange(alleBuecher);
            alleMedien.AddRange(alleZeitschriften);
            alleMedien.AddRange(alleMultimedias);

            double sumZeitschriften = alleZeitschriften.Sum(q => q.getPreis());
            double sumBuecher = alleBuecher.Sum(q => q.getPreis());
            double sumMultimedias = alleMultimedias.Sum(q => q.getPreis());
            double summeAll = sumMultimedias + sumZeitschriften + sumBuecher;

                Console.WriteLine($@"Im System sind aktuell folgende Medien gespeichert:
{sumBuecher:c2} Bücher
{sumZeitschriften:c2} Zeitschriften
{sumMultimedias:c2} Multimedias
___________________________
Summe: {summeAll:c2}


");

            alleMedien.Sort();
            foreach (var Medium in alleMedien)
            {
                Console.WriteLine(Medium);
            }
            Console.ReadLine();
        }
    }
}
