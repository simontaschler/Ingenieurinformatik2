using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bestellung> Bestellungsliste = new List<Bestellung>();
            Bestellungsliste.Add(new Bestellung("AsiaWok", 8.90));
            Bestellungsliste.Add(new Bestellung("Ali"));
            Bestellungsliste.Add(new Bestellung("Roberto", 9.80));
            Bestellungsliste.Add(new Bestellung("Test1", 8.9));
            Bestellungsliste.Add(new Bestellung(8.9));
            Bestellungsliste.Add(new Bestellung(8.9));
                        
                        
            foreach(Bestellung x in Bestellungsliste)
            {
                Console.WriteLine(x);
            }
            Console.Read();


        }
    }
}
