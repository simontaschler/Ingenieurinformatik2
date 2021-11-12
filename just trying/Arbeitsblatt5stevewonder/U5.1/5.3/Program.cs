using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Adressdaten Pers1= new Adressdaten("Stefan", "Huber", "Kaiserweg 5/8/81", "8010", "Graz");

            Adressbuch Adrb = new Adressbuch ();
            Adrb.AdressdatenListe.Add(Pers1);

            while (true)
            {
                Console.Clear();
                Console.WriteLine(@"Menü
*********************************
Adresse eingeben:           [1] *
Alle Adressen ausgeben:     [2] *
Nach Personen suchen:       [3] *
Programmende:               [4] *
*********************************");

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
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
                            Adrb.AdressdatenListe.Add(new Adressdaten(VNinput, NMinput, Straßeinput, PLZinput, Ortinput));

                            Console.Clear();
                            break;
                        }
                    case 2:
                        {
                            foreach (var Daten in Adrb.AdressdatenListe)
                            {
                                
                                Console.WriteLine(Daten);
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Geben Sie den Nachnamen der gesuchten Person ein!\n");
                            string searchfor = Console.ReadLine();
                            foreach (Adressdaten i in Adrb.AdressdatenListe)
                                if (searchfor == i.Nachname)
                                {
                                    Console.WriteLine(i.Vorname + ": " + i.Straße + "//" + i.Postleitzahl + " " + i.Ort);
                                }
                            break;
                        }
                    case 4:
                        {

                           return;
                        }

                }
                Console.ReadLine();

            }

        
         }   
        


                     

               
    }
}

