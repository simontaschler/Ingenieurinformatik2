using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Cli
{
    internal class House : RealEstate
    {
        //Konstante für maximale Anzahl an Mietern
        const int MAX_TENANTS = 4;
        private List<Tenant> Tenants = new();

        //MSBuild erstellt bei Auto-Properties automatisch im Hintergrund Getter- und Setter-Methoden
        //z.B. internal float get_Rent() bzw. internal void set_Rent(float value)
        //wenn diese Methoden nicht überschrieben werden, wird auch privates Feld angelegt, das den Wert speichert
        internal override float Rent { get; set; }

        //ToString-Methode von Object-Basisklasse überschrieben
        //wird automatisch aufgerufen, wenn man z.B. Console.Write() ein Object übergibt
        public override string ToString() =>
            //@-Prefix vor string für Multiline-Strings (anderes Escape-Pattern)
            //$-Prefix um in {} Expressions verwenden zu können, außerdem Performancevorteil ggü. Konkatenieren mit +
            //<float>:C2: als Währung mit 2 Nachkommastellen formatieren
            //string.Join fügt Collection zu einem string zusammen
            //Elemente werden mit angegebenem Separator (1. Parameter) unterteilt
            //ruft für jedes einzelnen Element der Collection ToString() auf
            $@"------------------Haus------------------
Adresse: {Address}
Gesamtmiete: {Rent:C2}
Mieter:
{string.Join(Environment.NewLine, Tenants)}";

        //Methode zum Hinzufügen von Mietern
        internal override bool AddTenant(Tenant tenant) 
        {
            if (tenant == null)
                return false;

            if (Tenants.Count < MAX_TENANTS)
            {
                Tenants.Add(tenant);
                Tenants.ForEach(q => q.RentToPay = CalcRent());
                //ForEach(q => ...): Linq-Methode als Kurzschreibweise von foreach-Schleifen, Lambda-Expression als Parameter
                //                   q repräsentiert Element in Collection, führt Aktion nach => für alle Elemente in Collection aus

                return true;
            }
            return false;
        }

        //Methode um zu zahlende Miete pro Mieter zu berechnen
        internal override float CalcRent() =>
            //Conditional Expression (kurzschreibweise für ifs): <logische Bedingung> ? <Wert wenn true> : <Wert wenn false>
            Tenants.Count == 0
                ? 0
                : (float)Math.Round(Rent / Tenants.Count, 2);

    }
}
