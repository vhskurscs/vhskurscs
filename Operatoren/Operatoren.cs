using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatoren
{
    class Operatoren
    {
        static void Main(string[] args)
        {
            //Zuweisungsoperator
            {
                int i = 42; //= ist Operator; i und 42 sind Operanden
            }

            //Arithmetische Operatoren
            {
                //Addition
                int a = 1254;
                int b = 42;
                int addition = a + b + 109023786;
                Console.WriteLine("Addition: " + addition);

                //Subtraktion
                int subtract = b - a;
                Console.WriteLine("Subtraktion: " + subtract);

                //Division
                double div = (double)a / b;
                Console.WriteLine("Division: " + div);

                //Multiplikation
                int mult = a * b;
                Console.WriteLine("Multiplikation: " + mult);

                //Modulo
                int mod = 12 % 7;
                Console.WriteLine("Modulo: " + mod);

                //Inkrementoperator
                int increment = 0;
                increment++; //Kurzform für: increment = increment + 1;
                ++increment;
                Console.WriteLine("Increment: " + increment);

                //Dekrementoperator
                int decrement = 2;
                decrement--;
                Console.WriteLine("Decrement1: " + decrement);
                --decrement;
                Console.WriteLine("Decrement2: " + decrement);

                //Besonderheit
                int num = 1;
                Console.WriteLine("Besonderheit: ");
                Console.WriteLine(num++);
                Console.WriteLine(num);
                Console.WriteLine(++num);

                //Arithmetische Zuweisung
                int num1 = 42;
                num1 += 10; // num1 = num1 + 10
                num1 -= 100;
                num1 *= 100;
                num1 /= 10000;
                num1 %= 5;
            }

            //Logische Operatoren
            {
                //Vergleichsoperatoren
                int num1 = 10;
                int num2 = 20;
                bool ergebnis = num1 < num2; //Kleiner
                Console.WriteLine("10 < 20: " + ergebnis);
                Console.WriteLine(num1 == num2); //Gleich
                Console.WriteLine(num1 != num2); //Ungleich
                Console.WriteLine(num1 > num2); //Größer
                Console.WriteLine(num1 <= num2); //Kleiner oder gleich
                Console.WriteLine(num1 >= num2); //Größer oder gleich

                //Boolesche Operatoren
                bool meinBool1 = true;
                bool meinBool2 = false;
                Console.WriteLine(meinBool1 & meinBool2); //Logische UND
                Console.WriteLine(meinBool1 | meinBool2); //Logisches ODER
                Console.WriteLine(meinBool1 ^ meinBool2); //Logisches Exklusives Oder (XOR)
                Console.WriteLine(!meinBool1); //Logisches NICHT
                Console.WriteLine(meinBool1 && meinBool2); //Intelligentes UND
                Console.WriteLine(meinBool1 || meinBool2); //Intelligentes ODER
            }

            {
                //Klammern
                int num = 12 + 5 * (5 - 17 / 4);
                Console.WriteLine(num);
            }


            Console.ReadLine();
        }
    }
}
