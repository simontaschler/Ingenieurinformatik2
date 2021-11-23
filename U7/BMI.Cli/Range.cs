using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI.Cli
{
    //für Fehlerbehandlung weitgehend irrelevant
    //
    //Generische Klasse Range für Intervall an BMI Normalgewicht für ein bestimmtes Alter
    //Generischer Type T repräsentiert einen beliebigen Datentyp, der das IComparable<T> interface implementiert
    //T wird bei Objektinstanzierung festgelegt, wird im Code dieser Klasse wie normaler DatenTyp verwendet
    internal class Range<T> where T : IComparable<T>
    {
        //MSBuild erstellt bei Auto-Properties automatisch im Hintergrund Getter-Methode
        //z.B. internal T get_Minimum()
        //wenn diese Methode nicht überschrieben wird, wird auch privates Feld angelegt, das den Wert speichert, Zugriff erfolgt aber immer über Property
        //wenn nur get-Operator angegeben wird, handelt es sich um readonly-Property, d.h. es können nur im Konstruktor oder bei der Deklaration Werte zugewiesen werden
        internal T Minimum { get; }
        internal T Maximum { get; }

        internal Range(T minimum, T maximum) 
        {
            Minimum = minimum;
            Maximum = maximum;
        }

        //Bestimmt ob Range gültig ist, d.h. Minimum kleiner als Maximum ist
        internal bool IsValid() => 
            Minimum.CompareTo(Maximum) <= 0;

        //Bestimmt, wo der übergebene Wert bezogen auf das Intervall liegt
        //0 wenn in Intervall
        //1 wenn oberhalb
        //-1 wenn unterhalb
        internal int CompareToValue(T value) 
        {
            if (Minimum.CompareTo(value) <= 0 && value.CompareTo(Maximum) <= 0)
                return 0;
            else if (Minimum.CompareTo(value) <= 0)
                return 1;
            else
                return -1;
        } 
    }
}
