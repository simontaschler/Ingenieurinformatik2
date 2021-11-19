using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var Pers1= new Adressdaten("Stefan", "Huber", "Kaiserweg 5/8/81", "8010", "Graz");  //Um von Beginn an eine Liste zu haben, wird zuerst eine erste Person manuell angelegt

            var Adrb = new Adressbuch ();    //Anschließend wird ein Objekt Adrb der Klasse Adressbuch angelegt
            Adrb.AdressdatenListe.Add(Pers1);       //In das Listen Attribut des Objektes Adrb wird nun das Objekt Pers1 der Klasse Adressdaten hinzugefügt

            while (true)        //Um das Programm solange weiterlaufen zu lassen, bis es durch Eingabemöglichkeit 4 beendet wird, wird zuerst eine Endlosschleife erstellt
            {
                Console.Clear();    //Die Konsole wird von verunreinigungen aus vorherigen Schleifendruchläufen bereinigt
                //@-Prefix vor string (verbatim string) für Multiline-Strings (anderes Escape-Pattern), Formatierung mit Linebreaks u.ä. wird aus Code übernommen 
                Console.WriteLine(@"Menü     
*************************************************
Adresse eingeben:...........................[1] *
Alle Adressen ausgeben:.....................[2] *
Nach Personen suchen:.......................[3] *
Nach Vorname sortieren und ausgeben:........[4] *
Nach VN und NM sortieren und ausgeben:......[5] *
Programmende:...............................[6] *
*************************************************");
                string menueinput = Console.ReadLine();
                int input = int.Parse(menueinput);  //Die Auswahl des Benutzers, welche Methode (1,2,3 oder 4) er ausführen möchte wird unter input gespeichert
                switch (input)  //Über die Switch, wird nun abgeglichen, welche Eingabe der Benutzer getätigt hat
                {
                    case 1:
                        {
                            Adrb.AdressDatenEinlesen(); //Bei Eingabe 1 wird die MEthode zum Einlesen neuer Adressdaten aufgerufen
                            break;  //break beendet die switch, und die endlos- Schleife bgeinnt von vorne
                        }
                    case 2:
                        {
                            Adrb.Ausgabe(); //Methode zur Ausgabe aller bisherig gespeicherten Adressdaten wird aufgerufen                            
                            break;  
                        }
                    case 3:
                        {
                            Adrb.Suche(); //Methode zur Suche nach Adressdaten durch Eingeben eines Nachnamens wird aufgerufen
                            break;
                        }
                    case 4:
                        {
                            Adrb.AdressdatenListe.Sort();   //Aufrufen des Standard- Sortierverfahren (Da die Klasse Adressdaten von IComparable erbt, wird dieser verwendet)
                            Adrb.Ausgabe();                 //Methodenaufruf zur Ausgabe
                            break;
                        }
                    case 5:
                        {
                            Adrb.AdressdatenListe.Sort(new VNuNMSortierung());  //Aufruf der IComparer Methode durch anlegen eines neuen IComparer Objektes
                            Adrb.Ausgabe();                                     //Methodeaufruf zur Ausgabe
                            break;
                        }
                    case 6:
                        {
                            return;     //Beendet die Main Methode
                        }
                    default:            //Wenn weder 1,2,3 oder 4 eingegeben wird, gibt die Konsule "Ungülltige Eingabe!" aus
                        {
                            Console.WriteLine("Ungülltige Eingabe!");   
                            break;
                        }
                }
            }        
         }              
    }
}

