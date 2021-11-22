using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._5
{
    class Zeitschrift:Medium
    {
        public Zeitschrift(string autor, string titel, string inventarnummer, int erscheinungsjahr, double preis) : base(erscheinungsjahr, titel, inventarnummer)
        {
            this.preis = preis;
            this.autor = autor;
            this.elektronischesMedium = false;
        }

        public override double getPreis() => preis * 1.1;
    }
}
