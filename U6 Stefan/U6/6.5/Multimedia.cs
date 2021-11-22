using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._5
{
    class Multimedia : Medium
    {
        public Multimedia(string autor, string titel, string inventarnummer, int erscheinungsjahr, double preis) : base(erscheinungsjahr, titel, inventarnummer)
        {
            this.preis = preis;
            this.autor = autor;
            this.elektronischesMedium = true;
        }

        public override double getPreis() => preis * 1.1;
        public override string ToString() => base.ToString() + " //e- Medium";
    }
}
