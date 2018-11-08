using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe1
{
    class Aufgabe1
    {
        static void Main(string[] args)
        {
            //----------------------------------------------------------------
            //Aufgabe 1.1
            //Erstelle Wahrheitstabellen (alle möglichen Kombinationen aus true und false) 
            //für die folgenden booleschen Operatoren und gebe sie auf der Konsole aus:
            //AND   &&
            //OR    ||
            //XOR   ^

            //Beispiel am Operator NOT !
            Console.WriteLine("Wahrheitstabelle NOT (!)");
            Console.WriteLine("!true = " + (!true));
            Console.WriteLine("!false = " + (!false));
            Console.WriteLine(); //leere Zeile ausgeben

            //Füge hier die übrigen hinzu


            //----------------------------------------------------------------
            //Aufgabe 1.2
            //Der Benutzer eine Zahl von 1-12 eingeben können.
            //Die Zahl soll anschließend in den Datentyp int konvertiert werden.
            //Mittels if-else-Verzweigung soll nun passend zur Zahl der Monatsname (Januar, ... etc.) ausgegeben werden.
            //Wenn eine falsche Zahl eingegeben wird, soll die Meldung "Das ist kein Monat!" ausgegeben werden.
            //Tipp: verwende die Methode Convert.ToInt32(), um die Benutzereingabe in einen int zu konvertieren.
            //      Siehe für ein Beispiel das Projekt "Einstieg" (dort wurde dasselbe gemacht, nur eben in float)



            //----------------------------------------------------------------
            //Aufgabe 1.3
            //Anhand der eingegeben Zahl aus Aufgabe 1.2 soll außerdem ermittels werden, in welcher Jahreszeit sich der
            //eingebene Monat befindet:
            //12-2: Winter
            //3-5: Frühling
            //6-8: Sommer
            //9-11: Herbst



            //----------------------------------------------------------------
            //Aufgabe 1.4
            //Der Benutzer soll eine beliebige positive Zahl eingeben.
            //Die Zahl soll anschließend in den Datentyp int konvertiert werden.
            //Prüfe, ob die Zahl gerade oder ungerade ist.
            //Gebe eine entsprechende Meldung aus: "Zahl ist gerade/Zahl ist ungerade".



            //----------------------------------------------------------------
            //Aufgabe 1.5
            //Der Benutzer soll 2 Zahlen eingeben können.
            //Diese sollen nun:
            //addiert, subtrahiert, dividiert und multipliziert
            //außerdem soll geprüft werden, ob die erste Zahl
            //kleiner, größer oder gleich der zweiten Zahl ist
            //Gebe für alle Berechnungen etc jeweils eine Meldung auf der Konsole aus
        }
    }
}
