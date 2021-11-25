using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U7
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;      //Programmwahl des Users
        Start:              //Sprungmarke Start für goto Statements
            Console.Clear();
            int i = 0;      //int i als Laufvariable für 1x1 lernen
            //Ausgabe des Menüs:
            Console.WriteLine(@"Wählen Sie ein Program:     
1x1 lernen              [1]
Zufallszahl ausgeben    [2]
Program beenden         [3]");
            try         //Try catch zum Abfangen falscher Eingaben (non numeric)
            {
                input = int.Parse(Console.ReadLine());
            }
            catch (FormatException) //FormatException, falls der input nicht in einen int geparst werden kann
            {
                Console.Clear();
                Console.WriteLine("Ungültige Eingabe, Press any key to return to start!");
                Console.ReadLine(); 
                goto Start;     //Program springt zur Start Sprungmarke
            }
            switch(input)           //Switch um die Programwahl weiter zu verarbeiten
            {
                case 1:     //7er Reihe wird abgefragt
                    while (i <= 10)
                    {
                       
                    FalscheAntwort:     //Sprungmare FalscheAntwort
                        int antwort;
                        try         //Try catch um non numeric inputs abzufangen
                        {
                            Console.WriteLine($"{i} * 7 = ?");
                            antwort = int.Parse(Console.ReadLine());                           
                        }
                        catch(FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe");
                            goto FalscheAntwort;
                        }
                        if (antwort == i * 7)       //if um die Eingabe auf Richtigkeit zu prüfen!
                        {
                            Console.WriteLine("Bravo!");
                            i++;
                        }
                        else
                        {
                            Console.WriteLine("Falsche Antwort... Versuch's nochmal");
                            goto FalscheAntwort;        //Falsche Antwort --> Neuer Versuch durch goto FalscheAntwort
                        }                    
                    }
                    Console.Clear();
                    Console.WriteLine("Geschafft! Du Mathekönig!!\nPress any key to continue");
                    Console.ReadLine();         //Hat man die 7er Reihe geschafft springt man durch eine willkürliche Eingabe zurück ins Startmenü
                    goto Start;
                    
                case 2:     //Case 2 Ausgabe einer Zufallszahl
                    Random rnd = new Random(); //Erstellen eines neuen Objekts der Random Klasse
                    int randomNumber = rnd.Next(1, 10);         //Aufrufen der next Methode des Random Objekts um eine Zufallszahl zwischen 1 und 10 zu erstellen
                    Console.WriteLine($@"Zufallszahl: {randomNumber}
Press any key to continue!");
                    Console.ReadLine();
                    goto Start;
                case 3:
                    return;         //return beendet die Main Methode
                default:        //Default falls zwar eine Zahl als PRogrammauswahl eingegeben wurde diese aber nicht zwischen 1 und 3 liegt
                    Console.Clear();
                    Console.WriteLine($"Ungültige Eingabe: {input}! nur Zahlen zwischen 1 und 3 zulässig!");
                    goto Start;                  
            }      
        }
    }
}
