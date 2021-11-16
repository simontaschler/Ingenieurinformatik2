using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freighter.Cli
{
    internal class TankContainer : Container
    {
        //readonly Feldern können nur im Konstruktor oder bei der Deklaration Werte zugewiesen werden
        private readonly double GasMass;
        private readonly double Pressure;
        private readonly double R;
        private readonly double Volume;

        //virtual Property aus Basisklasse überschrieben
        internal override double Temperature =>
            Pressure * Volume / (GasMass * R);

        //Ctor ruft mit : base(...) den Konstruktor der Basisklasse auf
        internal TankContainer(string content, double weight, double volume, double pressure, double gasMass) : base(content, weight) 
        {
            GasMass = gasMass;
            Pressure = pressure;
            R = content == "Helium" ? 2077 : 287;   //Conditional Expression (kurzschreibweise für ifs): <logische Bedingung> ? <Wert wenn true> : <Wert wenn false>
            Volume = volume;
        }

        //ToString-Methode von Object-Basisklasse überschrieben
        //wird automatisch aufgerufen, wenn man z.B. Console.Write() ein Object übergibt
        public override string ToString() =>
            //$-Prefix vor string (interpolated string) um in {} Expressions verwenden zu können, außerdem Performancevorteil ggü. Konkatenieren mit +
            //<double>:N2: double Wert wird zu string mit 2 Nachkommastellen formatiert
            $"Tankcontainer {ID}: {Content}, {Weight} t, {Temperature:N2} °C";
    }
}
