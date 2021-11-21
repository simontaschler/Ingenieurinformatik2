using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4
{
    class Frachtschiff
    {
        private Container[] allContainers = new Container[1];
        private string captain;
        private string destination;
        private bool isSpace;
        private double loadingWeight;
        private string shipName;
        private string start;
        private double weight;
        private int nextIndex = 0;              //Zusätzlich zur Angabe um das Array zu befüllen und resizen zu können
        private double actualweight = 0;        //Zusätzlich zur Angabe (Sinnhaftigkeit der Angabe nicht gegeben???)

        public Frachtschiff(string captain, string shipName, string start, string destination, double weight)
        {
            this.captain = captain;
            this.shipName = shipName;
            this.start = start;
            this.destination = destination;
            this.weight = weight;
        }
        public void addContainer(Container n)
        {
            if (getIsSpace())
            {
                if (nextIndex < allContainers.Length)
                {
                    allContainers[nextIndex] = n;
                    nextIndex++;
                }
                else
                {
                    Array.Resize(ref allContainers, nextIndex);
                    allContainers[nextIndex] = n;
                    nextIndex++;
                }
            }
            else
            {
                Console.WriteLine("Error 69: Schiff ist bereits voll beladen");
            }
            
        }
        public double calculateWeight()
        {
            double sum = 0;
            foreach (Container n in allContainers)
            {
               sum += n.getWeight();
            }
            this.actualweight = sum;
            return sum + weight;
        }
        public bool getIsSpace()
        {
            isSpace = loadingWeight < this.actualweight;
            return isSpace;
        }
        public void writeInfo()
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
