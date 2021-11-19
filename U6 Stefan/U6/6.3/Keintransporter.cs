using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3
{
    class Keintransporter : Fahrzeug        //Die Klasse Kleintransporter erbt von der Fahrzeug Klasse
    {
        private int ladevolumen;        //Zusätzlich enthält sie das Atribut ladevolumen
                                        //Dieses ist private (Datenkapselung) das es nur in dieser Methode gebraucht wird
        public override double calcVerbrauch()      //Die calcVerbrauch MEthode wird hier passend für die Klasse überschrieben/ festgelegt
        {
            return (10 * Math.Exp(ladevolumen / 10));
        }
        public Keintransporter(string name,int leistung, int reichweite, int ladevolumen)       //Konstruktor zum Erstellen eines Kleintransporter Objekts
        {
            this.name = name;
            this.leistung = leistung;
            this.reichweite = reichweite;
            this.ladevolumen = ladevolumen;
        }
        public override string ToString()       //Überschreiben der Standard ToString Methode um einen gewünschten Rückgabewert des Objekts festzulegen
        {
            return $"Das Fahrzeug Kleintransporter: {name} mit der Leistung {leistung} kW hat eine Reichweite von {reichweite} km!";
        }

    }
}
