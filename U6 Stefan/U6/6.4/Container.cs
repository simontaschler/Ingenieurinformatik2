using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4
{
    class Container         //neue Klasse Container
    {
        private int ID;                         //Festlegen der Attribute nach Klassendiagram
        private static int StaticID = 1;        //Die statische ID wird zu Beginn auf 1 festgelegt. mit jedem angelegten Objekt wird sie später um 1 vergrößert
        public string Ware;
        private double weight;     


        public Container (string Ware, double weight )      //Konstruktor für Objekte des Typs Container
        {
            this.ID = StaticID;                         //Die ID wird auf die aktuelle staticID festgelegt (Daher erhält jedes Objekt eine einzigartige ID automatsich zugewiesen)
            this.Ware = Ware;
            this.weight = weight;
            StaticID++;                 //StaticID wird für das nächste Objekt um 1 erhöht
        }
        public virtual double getTemperature() => 20;       //Methode zur Rückgabe der Temperatur (Die Standardtemperatur eines Containers beträgt 20Grad// durch virtual is die Methode überschreibbar!)
        public double getWeight() => this.weight;           //Methode zur Rückgabe des Gewichts
        public override string ToString() => $"ID: {ID}, Ware: {Ware}, Gewich: {weight}";   //Überschreiben der tostring Methode für erwünschtes Ausgabeformat






    }
}
