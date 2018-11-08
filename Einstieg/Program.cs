//Namensraum System wird eingebunden
using System;

//Eigener Namensraum Einstieg wird definiert
namespace Einstieg
{
    //Definieren einer neuen Klasse mit dem Namen Program
    class Program
    {
        //Definition der Main-Methode, dem Programmeinstiegspunkt
        static void Main(string[] args /*Programmargumente*/)
        {
            //Deklaration einer Variable von Typ Integer mit dem Namen i
            int i; 
            //Ausgabe auf die Konsole
            Console.WriteLine("Umrechnung Euro in Dollar.");
            /*
             * Das ist 
             * ein mehzeiliger 
             * Kommentar
             */
            //Defninition einer do-while-Schleife
            do //Führe folgenden Code solange aus, bis die Bedingung falsch ist
            {
                //Deklaration dreier Variablen vom Typ float
                float kurs, euro, dollar;
                Console.WriteLine("Wechselkurs: ");
                //Wertzuweisung von einer Benutezreingabe zur Variable kurs
                kurs = Convert.ToSingle(Console.ReadLine()); 
                Console.WriteLine("Euro: ");
                euro = Convert.ToSingle(Console.ReadLine());
                //Berechnung der dollar
                dollar = euro * kurs;

                Console.WriteLine("Sie erhalten " + dollar.ToString("0.00 $"));

                Console.WriteLine("Programm beenden? (j/n)");
                //Warten auf einen Tastendruck und zuweisen zur Variable s
                string s = Console.ReadKey().KeyChar.ToString();
                //Vergleich des strings s mit dem string "j"
                i = string.Compare(s, "j");
                //Abbruchbedingung der Schleife, wenn i gleich 0
            } while (i != 0); 
            //Ende der do-while-Schleife
        }
    }
}
