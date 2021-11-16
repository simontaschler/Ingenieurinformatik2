using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Cli
{
    internal class Magazine : Media
    {
        //Ctor ruft mit : base(...) den Konstruktor der Basisklasse auf
        internal Magazine(string author, string title, int releaseYear, string inventoryNumber, double price) : base(author, title, releaseYear, inventoryNumber, price, false)
        { }

        //abstrakte GetPrice Methode aus Basisklasse implementiert
        internal override double GetPrice() =>
            Price * 1.1;
    }
}
