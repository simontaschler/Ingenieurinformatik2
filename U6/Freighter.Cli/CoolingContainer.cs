using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freighter.Cli
{
    internal class CoolingContainer : Container
    {
        //readonly Feldern können nur im Konstruktor oder bei der Deklaration Werte zugewiesen werden
        private readonly string Type;

        //virtual Property aus Basisklasse überschrieben
        internal override double Temperature =>
            //Conditional Expression (kurzschreibweise für ifs): <logische Bedingung> ? <Wert wenn true> : <Wert wenn false>
            Type == "Tiefkühlprodukte"
                ? -20
                : 5;

        //weight als optionaler Parameter, wird wenn nicht übergeben mit gegebenem Wert initialisiert
        //muss dadurch nicht kompletten Overload für das Verwenden eines Standardwertes schreiben, der wird beim Build automatisch erstellt
        //Ctor ruft mit : base(...) den Konstruktor der Basisklasse auf
        internal CoolingContainer(string content, string type, double weight = 1) : base(content, weight) =>
            Type = type;

        //ToString-Methode von Object-Basisklasse überschrieben
        //wird automatisch aufgerufen, wenn man z.B. Console.Write() ein Object übergibt
        public override string ToString() =>
            //$-Prefix vor string (interpolated string) um in {} Expressions verwenden zu können, außerdem Performancevorteil ggü. Konkatenieren mit +
            //<double>:N2: double Wert wird zu string mit 2 Nachkommastellen formatiert
            $"Kühlcontainer {ID}: {Content}, {Weight} t, {Temperature:N2} °C, {Type}";

    }
}
