using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flusskontrolle1
{
    class Program
    {
        static void Main(string[] args)
        {
            //If - Else Verzweigung
            Console.Write("Passwort: ");
            string pw = Console.ReadLine();
            if (pw == "password")
            {
                Console.WriteLine("Du hast zugriff!");
            }
            else
            {
                Console.WriteLine("Zugriff verweigert!");
            }
            Console.WriteLine("Nach if-else");
            Console.WriteLine();

            int zensur = 3;
            if(zensur == 1)
            {
                Console.WriteLine("Sehr gut!");
            }
            else if (zensur == 2)
            {
                Console.WriteLine("Gut");
            }
            else if (zensur == 3)
            {
                Console.WriteLine("Befriedigend");
            }
            else
            {
                Console.WriteLine("Das ist nicht besonders...");
            }

            //switch-case
            int monat = 5;
            switch(monat) //
            {
                case 1: Console.WriteLine("Januar"); break;
                case 2: Console.WriteLine("Februar"); break;
                case 3: Console.WriteLine("März"); break;
                case 4: Console.WriteLine("April"); break;
                case 5: Console.WriteLine("Mai"); break;
                case 6: Console.WriteLine("Juni"); break;
                case 7: Console.WriteLine("Juli"); break;
                case 8: Console.WriteLine("August"); break;
                case 9: Console.WriteLine("September"); break;
                case 10: Console.WriteLine("Oktober"); break;
                case 11: Console.WriteLine("November"); break;
                case 12: Console.WriteLine("Dezember"); break;
                default: Console.WriteLine($"{monat} ist kein Monat"); break;
            }

            //Hinweis: Ohne break-Statement wird auch der nächste case ausgeführt.
            //         Das geht solange weiter, bis das nächste break-Statement erreicht wird.
            //         Das kann sowohl Fehlerquelle, als auch ein Vorteil sein (siehe Beispiel).
            switch (monat)
            {
                case 12: case 1: case 2: Console.WriteLine("Winter"); break;
                case 3: case 4: case 5: Console.WriteLine("Frühling"); break;
                case 6: case 7: case 8: Console.WriteLine("Sommer"); break;
                case 9: case 10: case 11: Console.WriteLine("Herbst"); break;
            }

            Console.ReadLine();
        }
    }
}
