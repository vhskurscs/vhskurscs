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
            //If-Else Verzweigung
            //Console.Write("Passwort: ");
            //string pw = Console.ReadLine();
            //if(pw == "password")
            //{
            //    Console.WriteLine("Du hast zugriff!");
            //}
            //else
            //{
            //    Console.WriteLine("Zugriff verweigert!");
            //}

            //Console.WriteLine("Nach if-else");

            int zensur = 3000;
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

            Console.ReadLine();
        }
    }
}
