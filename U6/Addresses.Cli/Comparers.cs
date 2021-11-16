using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addresses.Cli
{
    //IComparer<T>:
    //Generische Variante des IComparer Interfaces, Compare Methode erwartet Parameter vom Typ T anstatt object
    //Parameter müssen ggü. nicht-generischen Variante nicht mit Reflection (schlechte Performance) auf Datentyp überprüft werden
    //deshalb nur bei Collections, wo sicher ist, dass alle Elemente Typ T haben (z.B. List<T> oder T[]), zu verwenden
    internal class FullNameComparer : IComparer<Address>
    {
        //Compare(T x, T y):
        //Compare-Methode des IComparer<T> Interfaces, erwartet Parameter des Typs ToList
        //gibt int > 0 zurück, wenn x als größer als y zu betrachten ist
        //gibt int < 0 zurück, wenn x als kleiner als y zu betrachten ist
        //gibt 0 zurück, wenn x als gleich y zu betrachten ist
        public int Compare(Address x, Address y) =>
            //führt Standard-StringComparison mit FullName-Properties der Objekte durch
            //Ausdruck?.Aufruf: integrierter null-Check, wenn Ausdruck vor ?. null ist, wird gesamter Ausdruck mit nachfolgenden Aufrufen als null angenommen
            //					zum Verhindern von Aufrufen über null und daraus folgenden System.NullReferenceExceptions
            StringComparer.Ordinal.Compare(x?.FullName, y?.FullName);
    }

    //siehe FullNameComparer
    internal class LastNameComparer : IComparer<Address> //Statt Alter, weil es in 5.3 keine Eigenschaft Alter gibt, für Vorgehensweise bei order by x then by y egal
    {
        //siehe FullNameComparer.Compare
        public int Compare(Address x, Address y)
        {
            //führt Standard-StringComparison mit LastName-Properties der Objekte durch
            //Ausdruck?.Aufruf: integrierter null-Check, wenn Ausdruck vor ?. null ist, wird gesamter Ausdruck mit nachfolgenden Aufrufen als null angenommen
            //					zum Verhindern von Aufrufen über null und daraus folgenden System.NullReferenceExceptions
            var comparisonResult = StringComparer.Ordinal.Compare(x?.LastName, y?.LastName);

            //Conditional Expression (kurzschreibweise für ifs): <logische Bedingung> ? <Wert wenn true> : <Wert wenn false>
            return comparisonResult != 0                                        //Wenn bei Comparison der LastNames 0 herauskommt sollen FirstNames verglichen werden
                ? comparisonResult
                : StringComparer.Ordinal.Compare(x?.FirstName, y?.FirstName);
        }
    }
}
