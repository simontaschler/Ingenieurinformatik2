using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U5._1
{
    class Zirkus
    {

//Atribute des Zirkus festlegen
        public string circusName { get; set; }
        public Tiertrainer tierTrainer { get; set; }
        private int nextIndex = 0;      //nextIndex beschreibt die jeweils nächste freie Position im tierarray

//Erstellen eines Arrays in dem alle Tier- Objekte gespeicher werden
        Tier[] tierarray;

 //Konstruktor zum Erstellen von Zirkus Objekten
        public Zirkus (string circusName, int größe, Tiertrainer tierTrainer )
        {
            this.circusName = circusName;
            this.tierTrainer = tierTrainer;
            tierarray = new Tier[größe];
        }


//Überprüfe ob der Zirkus bereits voll ist
        public void Tierhinzufügen(Tier animal)
        {
            if(nextIndex>=tierarray.Length) //Wenn die nächste freie Position (nextIndex) außerhalb der Array Größe liegt, ist der Zirkus voll!
            {
                Console.WriteLine("Circus " + circusName + " ist bereits voll!");   //Ausgabe dass der Zirkus voll ist
            }
            else
            {
                tierarray[nextIndex] = animal;      //Wenn die nächste freie Position noch im Array liegt, sowird das Tier Objekt im Array an der freien Position gespeichert
                nextIndex++;                        //Anschließend springt der nextIndex eins weiter, da die aktuelle Position ja nun belegt ist

            }        
        }


//Ausgabe in der Konsole
        public void Ausgabe()
//Zirkusname, sowie Trainername werden einfach über console.writeline(...); ausgegeben
        {    
            Console.WriteLine("***********************************" + circusName + "***********************************");
            Console.WriteLine("Zirkustrainer:\n                 " + tierTrainer.nameTrainer + "\nTiere:");

 //Um die Tiere auszugeben ist eine foreach- Schleife notwendig, welche alle Elemente n im Tierarray einzeln ausgibt.
 //Dafür wird die Methode Tierasugabe aus der Klasse Tiere für jedes Element n einzeln aufgerufen
            foreach (var n in tierarray)
            {
                n.Tierausgabe();        //Zugriff auf die Methode Tierausgabe (n beschreibt daher immer ein Tierobjekt)
            }


        }
    }
}
