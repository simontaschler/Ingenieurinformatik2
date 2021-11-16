using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U5._1
{
    public class Zirkus
    {
        //MSBuild erstellt bei Auto-Properties automatisch im Hintergrund Getter-Methode
        //z.B. public string get_Name()
        //wenn diese Methode nicht überschrieben wird, wird auch privates Feld angelegt, das den Wert speichert, Zugriff erfolgt aber immer über Property
        //wenn nur get-Operator angegeben wird, handelt es sich um readonly-Property, d.h. es können nur im Konstruktor Werte zugewiesen werden
        public string Name { get; }
        public TierTrainer Trainer { get; }

        private Tier[] tiere;           //Feld für Array in dem alle Tier-Objekte gespeichert werden
        private int nextIndex = 0;      //Feld für den nächsten freien Index im Array tiere

        //Konstruktor zum Erstellen von Zirkus Objekten
        public Zirkus (string circusName, int größe, TierTrainer tierTrainer )
        {
            Name = circusName;
            Trainer = tierTrainer;
            tiere = new Tier[größe]; //Feld wird mit neuem Array initialisiert
        }

        //Überprüfe ob der Zirkus bereits voll ist
        public void AddTier(Tier animal)
        {
            if (animal == null)     //Wenn leeres Objekt übergeben wird soll gar nicht versucht werden es dem Array hinzuzufügen
                return;

            if(nextIndex >= tiere.Length) //Wenn die nächste freie Position (nextIndex) außerhalb der Array Größe liegt, ist der Zirkus voll!
            {
                //Ausgabe dass der Zirkus voll ist
                //$-Prefix vor string (interpolated string) um in {} Expressions verwenden zu können, außerdem Performancevorteil ggü. Konkatenieren mit +
                Console.WriteLine($"Circus {Name} ist bereits voll!");
            }
            else
            {
                tiere[nextIndex] = animal;      //Wenn die nächste freie Position noch im Array liegt, sowird das Tier Objekt im Array an der freien Position gespeichert
                nextIndex++;                    //Anschließend springt der nextIndex eins weiter, da die aktuelle Position ja nun belegt ist
            }        
        }

        //Ausgabe in der Konsole
        public void Ausgabe()
        {
            //Zirkusname, sowie Trainername werden einfach über Console.writeline(...); ausgegeben
            //$-Prefix vor string (interpolated string) um in {} Expressions verwenden zu können, außerdem Performancevorteil ggü. Konkatenieren mit +
            Console.WriteLine($"***********************************{Name}***********************************");
            Console.WriteLine($"Zirkustrainer:\n                 {Trainer.Name}\nTiere:");

            //Um die Tiere auszugeben ist eine foreach- Schleife notwendig, welche alle Elemente n im Tierarray einzeln ausgibt.
            //Dafür wird die Methode TierAusgabe aus der Klasse Tiere für jedes Element n einzeln aufgerufen
            foreach (var tier in tiere)
                tier.Ausgabe();        //Zugriff auf die Methode Tierausgabe (n beschreibt daher immer ein Tierobjekt)
        }
    }
}
