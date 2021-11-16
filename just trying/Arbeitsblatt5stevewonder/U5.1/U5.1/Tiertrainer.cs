using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U5._1
{
    public class TierTrainer
    {
        //MSBuild erstellt bei Auto-Properties automatisch im Hintergrund Getter-Methode
        //z.B. public string get_Name()
        //wenn diese Methode nicht überschrieben wird, wird auch privates Feld angelegt, das den Wert speichert, Zugriff erfolgt aber immer über Property
        //wenn nur get-Operator angegeben wird, handelt es sich um readonly-Property, d.h. es können nur im Konstruktor Werte zugewiesen werden
        public string Name { get; }

        public TierTrainer(string name) =>   //Konstruktur für Tiertrainer Objekte 
            Name = name;         //Der Inputwert des Konstruktors wird im Objekt unter der Eigenschaft Name gespeichert
    }
}
