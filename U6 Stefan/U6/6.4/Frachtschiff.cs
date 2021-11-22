using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4
{
    class Frachtschiff      //klasse Frachtschiff
    {
        private Container[] allContainers = new Container[1];       //Frachtschiff Objekte erhalten ein Array mit allen Containern als Attribut (Standardgröße ist 1) 
        private string captain;                                     //Weitere Attribute werden laut Angabe erstellt
        private string destination;
        private bool isSpace;
        private double loadingWeight;
        private string shipName;
        private string start;
        private double weight;
        private int nextIndex = 0;              //Zusätzlich zur Angabe um das Array zu befüllen und resizen zu können
        private double actualweight = 0;        //Zusätzlich zur Angabe (Sinnhaftigkeit der Angabe nicht gegeben???)

        public Frachtschiff(string captain, string shipName, string start, string destination, double weight)       //Konstruktor zur Erstellung neuer Frachtschiff Objekte
        {
            this.captain = captain;
            this.shipName = shipName;
            this.start = start;
            this.destination = destination;
            this.weight = weight;
        }
        public void addContainer(Container n)       //Methode zum hinzufügen von neuen Containern auf das Frachtschiff
        {
            if (getIsSpace())                       //Abfrage ob noch Platz ist
            {
                if (nextIndex < allContainers.Length)       //Abfrage  ob das allContainers Array bereits voll ist um es gegbenenfalls (else) zu vergrößern
                {
                    allContainers[nextIndex] = n;           //Durch die Variable nextIndex kann jedem Container nach und nach ein eigener Platz im Array zugewiesen werden
                    nextIndex++;                            //nextIndex++ setzt die Stelle für das nächste Objekt an die nächste Position im Array
                }
                else
                {
                    Array.Resize(ref allContainers, nextIndex);     //Erweitern der Array Größe falls nötig
                    allContainers[nextIndex] = n;
                    nextIndex++;
                }
            }
            else
            {
                Console.WriteLine("Error 69: Schiff ist bereits voll beladen"); //Erros falls getIsSpace=false
            }
            
        }
        public double calculateWeight()             //Methode zur Berechnung des Gesamtgewichts des beladenen Frachtschiffes
        {
            double sum = 0;                         //sum beschreibt das Gesamtgewicht aller Container und wird zu beginn auf 0 gesetzt
            foreach (Container n in allContainers)  //mit der foreach Schleife wird die getweight Methode für jeden Container im allContainers Array augerufen und zur summe addiert
            {
               sum += n.getWeight();
            }
            this.actualweight = sum;            //actualweight bekommt den Wert des Gesamtgewichtes aller Container
            return sum + weight;                //Als return Wert wird das Gesamtgewicht aller Container mit dem Gewicht des Frachschiffes addiert
        }
        public bool getIsSpace()                    //Methode zur Überprüfung ob noch Platz am Schiff ist
        {
            isSpace = loadingWeight < this.actualweight;        //Logische Abfrage um den bool true oder false zu setzen
            return isSpace;
        }
        public void writeInfo()     //Methode zur Ausgbe sämtlicher Informationen des Frachschiffes
        {
            Console.WriteLine($"Frachtschiff {shipName} (Kapitän: {captain}) mit einer max. loading weight von {loadingWeight}t und einem Gewicht von {weight}t, fährt von {start} nach {destination}! Folgende Fracht ist an Bord:");
            foreach (Container n in allContainers)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine($"************************\nDie aktuelle Gesamtgewicht beträgt daher {calculateWeight()}t!");
        }
    }
}
