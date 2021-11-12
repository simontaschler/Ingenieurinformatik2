using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._4
{
    class Bestellung
    {
        public string Name;
        public double Preis;
        private static int Bestellnummer = 1;

        

        public Bestellung(string Name, double Preis)
        {
            this.Name = Name;
            this.Preis = Preis;
            string AusgabeNr =(Bestellnummer.ToString().PadLeft(3,'0'));
            Console.WriteLine($"{AusgabeNr}\t{Name}\t\t{Preis}");
            Bestellnummer++;
        }
        public Bestellung(double Preis)
        {
            this.Name = "???";
            this.Preis = Preis;
            string AusgabeNr = (Bestellnummer.ToString().PadLeft(3, '0'));
            Console.WriteLine($"{AusgabeNr}\t{Name}\t\t{Preis}");
            Bestellnummer++;
        }
        public Bestellung(string Name)
        {
            this.Name = Name;
            this.Preis = 0;
            string AusgabeNr = (Bestellnummer.ToString().PadLeft(3, '0'));
            Console.WriteLine($"{AusgabeNr}\t{Name}\t\t{Preis}");
            Bestellnummer++;
        }

        
        
            
        

    
    }
}
