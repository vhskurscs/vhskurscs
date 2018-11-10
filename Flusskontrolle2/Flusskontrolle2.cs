using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flusskontrolle2
{
    /// <summary>
    /// Flusskontrolle - Schleifen (Loops)
    /// for, while, do-while
    /// </summary>
    class Flusskontrolle2
    {
        static void Main(string[] args)
        {
            //while-Schleife
            {
                int i = 0; //Zählervariable (meist Index genannt)
                while (i < 10) //Bedingung (muss boolescher Natur sein [true | false])
                {
                    Console.WriteLine("i ist: " + i);
                    i++; //Wenn eine zählervariable verwendet wird, sollte diese auch verändert werden,
                         //sonst droht eine Endlosschleife
                }
            }

            //for-Schleife
            {
                //Hinweis: Zeilenumbrüche wurden nur für die Kommentare eingefügt
                for (int i = 0; //Initialisierung nur bei BEGINN der Schleife (1-mal)
                 i < 10; //Abbruchbedingung VOR jedem Durchlauf
                 i++) //Änderung der Zählervariable NACH jedem Durchlauf
                {
                    Console.WriteLine("for - i ist: " + i);
                }
            }

            //do-while-Schleife
            {
                int i = 0;
                //do-while-Schleife (Code-block wird definitiv mind. 1-mal ausgeführt)
                do
                {
                    Console.WriteLine("do-while - i ist: " + i);
                    i++;
                } while (i < 10);
            }

            //--------------------------------------------------------------
            // BEISPIELE
            //--------------------------------------------------------------
            
            //Zahlen von 1 - 10 addieren
            //mit for-Schleife
            {
                int summe = 0;
                for (int i = 1; i <= 10; i++)
                {
                    summe = summe + i;
                }
                Console.WriteLine("for - Summe: " + summe);
            }
            //mit while-Schleife
            {
                int i = 1;
                int summe = 0;
                while (i <= 10)
                {
                    summe += i;
                    i++;
                }
                Console.WriteLine("while - Summe: " + summe);
            }
            //mit do-while-Schleife
            {
                int i = 1;
                int summe = 0;
                do
                {
                    summe += i;
                    i++;
                } while (i <= 10);
                Console.WriteLine("do-while - Summe: " + summe);
            }

            //Random
            {
                Random rand = new Random(); //Object vom typ Random instanziieren
                int meinRandom = rand.Next(7); //Zufalls-Ganzzahl von 0-6 generieren
                Console.WriteLine("meinRandom: " + meinRandom);
                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine("Random: " + (rand.Next(6) + 1)); //Zufallszahl von 1-6
                }
            }

            //Strings Zeichen für Zeichen (char) verarbeiten
            {
                string meinString = "Hallo ich bin ein String";
                for (int i = 0; i < meinString.Length; i++)
                {
                    //Console.WriteLine(meinString[i]);
                    if (meinString[i] == 'i')
                    {
                        Console.WriteLine("An der Stelle " + i + " ist ein kleines i");
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
