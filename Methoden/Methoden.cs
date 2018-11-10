using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methoden
{
    class Methoden
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Methoden");

            //Methode aufrufen
            double ergebnis = Rechner.Addieren(12.0, 11.5);

            Console.WriteLine(Rechner.Addieren(1.0, 2.0, 45.0));

            //Console.WriteLine("Ergebnis: " + ergebnis);

            Rechner.Print("Ergebnis: " + ergebnis);

            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
