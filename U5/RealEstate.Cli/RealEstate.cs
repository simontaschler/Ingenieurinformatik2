using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Cli
{
    internal abstract class RealEstate
    {
        //MSBuild erstellt bei Auto-Properties automatisch im Hintergrund Getter- und Setter-Methoden
        //z.B. internal float get_Rent() bzw. internal void set_Rent(float value)
        //wenn diese Methoden nicht überschrieben werden, wird auch privates Feld angelegt, das den Wert speichert
        //abstrakte Properties müssen mit gegebenen get-/set-Methoden von Derivaten überschrieben werden
        internal abstract float Rent { get; set; }    //Miete als abstract Property, weil bei Wohnung 5% Förderung berücksichtigt werden muss
        internal string Address { get; set; }

        //abstrakte Methoden müssen von Derivaten implementiert werden
        internal abstract bool AddTenant(Tenant tenant); //Methode um Mieter hinzuzufügen mit bool return type für Info, ob noch Platz war (true wenn ja)
        internal abstract float CalcRent();

        //ToString-Methode von Object-Basisklasse muss überschrieben werden
        //wird automatisch aufgerufen, wenn man z.B. Console.Write() ein Object übergibt
        public abstract override string ToString();
    }
}
