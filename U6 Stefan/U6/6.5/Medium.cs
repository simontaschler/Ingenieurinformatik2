using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._5
{
    abstract class Medium:IComparable<Medium>
    {
        public string autor;
        public bool elektronischesMedium;
        public double preis;
        private int erscheinungsJahr;
        private string inventarNummer;
        private string titel;
        public Medium(int erscheinungsjahr,string titel, string inventarnummer)
        {
            this.titel = titel;
            this.erscheinungsJahr = erscheinungsjahr;
            this.inventarNummer = inventarnummer;
        }

        public int CompareTo(Medium other) => autor.CompareTo(other.autor);                        

        public abstract double getPreis();
        public override string ToString() => $"Autor: {autor}, Titel: {titel}, Inv. Nr.: {inventarNummer}";        
    }
}
