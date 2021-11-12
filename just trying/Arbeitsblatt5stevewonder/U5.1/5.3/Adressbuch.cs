using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3
{
    class Adressbuch //Klasse Adressbuch
    {
        public List<Adressdaten> AdressdatenListe = new List<Adressdaten>();
          
        public void AdressDatenEinlesen()
        {
            Console.Clear();
            Console.WriteLine("Bestätigen Sie jede Eingabe mit der Enter Taste!\nGeben Sie den Vornamen ein!");
            string VNinput = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Geben Sie den Nachnamen ein!");
            string NMinput = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Geben Sie die Straße inkl. Hausnummer/Stock/Tür ein!");
            string Straßeinput = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Geben Sie die Postleitzahl ein");
            string PLZinput = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Geben Sie den Ort ein!");
            string Ortinput = Console.ReadLine();
            Console.WriteLine("Bestätigen Sie mit Enter!");
            AdressdatenListe.Add(new Adressdaten(VNinput, NMinput, Straßeinput, PLZinput, Ortinput));

            Console.Clear();
            
        }
        public void Ausgabe()
        {
            foreach (var Daten in AdressdatenListe)
            {

                Console.WriteLine(Daten);
            }
        }    
        public void Suche()
        {
            Console.Write("Geben Sie den Nachnamen der gesuchten Person ein!\n");
            string searchfor = Console.ReadLine();
            foreach (Adressdaten i in AdressdatenListe)
                if (searchfor == i.Nachname)
                {
                    Console.WriteLine(i.Vorname + ": " + i.Straße + "//" + i.Postleitzahl + " " + i.Ort);
                }
        }
            
    
    
    
    }

}
