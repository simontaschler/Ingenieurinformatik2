using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Cli
{
    //IComparable<T>:
    //Generische Variante des IComparable Interfaces, CompareTo Methode erwartet Parameter vom Typ T anstatt object
    //Speziefischer Overload von CompareTo für Vergleiche mit bestimmten Datentyp, ohne, wie bei nicht-generischem IComparable, 
    //mit Reflection (schlechte Performance) Objekt auf Datentyp überprüfen zu müssen
    internal abstract class Media : IComparable<Media>
    {
        protected string Author;
        protected bool IsElectronicMedia;
        protected double Price;
        //readonly Feldern können nur im Konstruktor oder bei der Deklaration Werte zugewiesen werden
        private readonly int ReleaseYear;
        private readonly string InventoryNumber;
        private readonly string Title;

        internal Media(string author, string title, int releaseYear, string inventoryNumber, double price, bool isElectronicMedia) 
        {
            Author = author;
            Title = title;
            ReleaseYear = releaseYear;
            InventoryNumber = inventoryNumber;
            Price = price;
            IsElectronicMedia = isElectronicMedia;
        }

        //Methode GetPrice als abstract, damit sie von Derivaten überschrieben werden muss
        internal abstract double GetPrice(); 

        //CompareTo(T other):
        //CompareTo-Methode des IComparable<T> Interfaces, erwartet Parameter des Typs T
        //gibt int > 0 zurück, wenn aktuelle Instanz als größer als Parameter zu betrachten ist
        //gibt int < 0 zurück, wenn aktuelle Instanz als kleiner als Parameter zu betrachten ist
        //gibt 0 zurück, wenn aktuelle Instanz als gleich dem Parameter zu betrachten ist
        public int CompareTo(Media other) => 
            Author.CompareTo(other.Author);

        //ToString-Methode von Object-Basisklasse überschrieben
        //wird automatisch aufgerufen, wenn man z.B. Console.Write() ein Object übergibt
        public override string ToString() =>
            //$-Prefix vor string (interpolated string) um in {} Expressions verwenden zu können, außerdem Performancevorteil ggü. Konkatenieren mit +
            $"Autor: {Author}, Titel: {Title}, Inventarnummer: {InventoryNumber}";
    }
}
