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
                            Adrb.AdressDatenEinlesen();
                            break;
                        }
                    case 2:
                        {
                            Adrb.Ausgabe();
                            break;
                        }
                    case 3:
                        {
                            Adrb.Suche();
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

