using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Cli
{
    internal class Apartment : RealEstate
    {
        //Konstante für maximale Anzahl an Mietern
        const int MAX_TENANTS = 3;
        private Tenant[] Tenants = new Tenant[MAX_TENANTS];
        private int nextTenantIndex = 0;

        //MSBuild erstellt bei Properties automatisch im Hintergrund Getter- und Setter-Methoden
        //z.B. internal float get_Rent() bzw. internal void set_Rent(float value)
        //diese Methoden werden hier überschrieben, weswegen von MSBuild kein privates Feld generiert wird und ein eigenes angelegt werden muss
        private float _rent;
        internal override float Rent 
        {
            get => _rent;
            set => _rent = (float)Math.Round(value * 0.95, 2); 
        }

        //ToString-Methode von Object-Basisklasse überschrieben
        //wird automatisch aufgerufen, wenn man z.B. Console.Write() ein Object übergibt
        public override string ToString() =>
            //@-Prefix vor string für Multiline-Strings (anderes Escape-Pattern)
            //$-Prefix um in {} Expressions verwenden zu können, außerdem Performancevorteil ggü. Konkatenieren mit +
            //<float>:C2: als Währung mit 2 Nachkommastellen formatieren
            //string.Join fügt Collection zu einem string zusammen
            //Elemente werden mit angegebenem Separator (1. Parameter) unterteilt
            //ruft für jedes einzelnen Element der Collection ToString() auf
            $@"------------------Wohnung------------------
Adresse: {Address}
Gesamtmiete: {Rent:C2}
Mieter:
{string.Join(Environment.NewLine, Tenants as object[])}";

        //Methode zum Hinzufügen von Mietern
        internal override bool AddTenant(Tenant tenant) 
        {
            if (tenant == null)
                return false;

            if (nextTenantIndex < MAX_TENANTS)
            {
                Tenants[nextTenantIndex] = tenant;
                nextTenantIndex++;
                for (var i = 0; i < nextTenantIndex; i++) //Zu zahlende Miete für alle Mieter aktualisieren
                    Tenants[i].RentToPay = CalcRent();
                return true;
            }
            return false;
        }

        //Methode um zu zahlende Miete pro Mieter zu berechnen
        internal override float CalcRent() => 
            //Conditional Expression (kurzschreibweise für ifs): <logische Bedingung> ? <Wert wenn true> : <Wert wenn false>
            nextTenantIndex == 0
                ? 0
                : (float)Math.Round(Rent / nextTenantIndex, 2);

    }
}
