using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Cli
{
    internal class Order
    {
        //statisches Feld: nicht über Object-Instanz sondern nur über Klasse aufrufbar, d.h. Wert für alle Objekte gleich
        private static int nextID = 1;

        private readonly string Name;
        private readonly float Price;
        private readonly int ID;
    
        internal Order(string name, float price = 0F /*optionaler Parameter, wird wenn nicht übergeben mit gegebenem Wert initialisiert*/) 
        {
            Name = name;
            Price = price;
            ID = nextID;
            nextID++;
        }

        //Overload des Konstruktors, Compiler kann anhand von Parametern entscheiden, welcher zu verwenden ist
        internal Order(float price = 0F /*optionaler Parameter, wird wenn nicht übergeben mit gegebenem Wert initialisiert*/)
        {
            Name = "???";
            Price = price;
            ID = nextID;
            nextID++;
        }

        //ToString-Methode von Object-Basisklasse überschrieben
        //wird automatisch aufgerufen, wenn man z.B. Console.Write() ein Object übergibt
        public override string ToString() =>
            $"{ID}: {Name}, {Price:C2}";
    }
}
