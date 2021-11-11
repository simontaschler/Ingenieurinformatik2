using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U5._1
{
    class Tiertrainer
    {
        public string nameTrainer { get; set; }     //Öffentliche Methode die TierTrainer Objekten die Eigenschaft nameTrainer zuweist

        public Tiertrainer(string nameTrainer)      //Konstruktur für Tiertrainer Objekte 
        {
            this.nameTrainer = nameTrainer;         //Der Inputwert des Konstruktors wird im Objekt unter der Eigenschaft nameTrainer gespeichert
        }
    }

}
