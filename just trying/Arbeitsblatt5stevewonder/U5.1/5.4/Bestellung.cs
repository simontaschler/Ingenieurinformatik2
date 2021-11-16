using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._4
{
    public class Bestellung
    {
        private readonly string Name;
        private readonly double Preis;
        private readonly int Bestellnummer;
        private static int nextBestellnummer = 1;

        public Bestellung(string name, double preis)
        {
            Name = name;
            Preis = preis;
            Bestellnummer = nextBestellnummer;
            nextBestellnummer++;
        }

        public Bestellung(double preis)
        {
            Name = "???";
            Preis = preis;
            Bestellnummer = nextBestellnummer;
            nextBestellnummer++;
        }

        public Bestellung(string name)
        {
            Name = name;
            Preis = 0;
            Bestellnummer = nextBestellnummer;
            nextBestellnummer++;
        }

        public override string ToString() => 
            $"{Bestellnummer.ToString().PadLeft(3, '0')}\t{Name}\t\t{Preis}";
    }
}
