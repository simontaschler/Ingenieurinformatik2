using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Cli
{
    internal class MultiMedia : Media
    {
        //Ctor ruft mit : base(...) den Konstruktor der Basisklasse auf
        internal MultiMedia(string author, string title, int releaseYear, string inventoryNumber, double price) : base(author, title, releaseYear, inventoryNumber, price, true)
        { }

        //abstrakte GetPrice Methode aus Basisklasse implementiert
        internal override double GetPrice() => 
            Price * 1.2;

        //ToString-Methode von Object-Basisklasse überschrieben
        //wird automatisch aufgerufen, wenn man z.B. Console.Write() ein Object übergibt
        public override string ToString() =>
            //$-Prefix vor string (interpolated string) um in {} Expressions verwenden zu können, außerdem Performancevorteil ggü. Konkatenieren mit +
            $"{base.ToString()}, e-Medium";
    }
}
