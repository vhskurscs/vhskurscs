using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methoden
{
    /// <summary>
    /// Stellt statische Methoden für Rechenoperationen bereit.
    /// </summary>
    class Rechner
    {
        /// <summary>
        /// Addiert zwei Zahlen.
        /// </summary>
        /// <param name="num1">Operand 1</param>
        /// <param name="num2">Operand 2</param>
        /// <returns>Summe der beiden Zahlen</returns>
        public static double Addieren(double num1, double num2)
        {
            //double ergebnis = num1 + num2;
            //return ergebnis;
            return num1 + num2; //Kurzform
        }
        //Überladene Methode
        public static double Addieren(int num1, int num2)
        {
            return num1 + num2;
        }
        //Nochmals überladene Methode
        public static double Addieren(double num1, double num2, double num3)
        {
            return num1 + num2 + num3;
        }

        /// <summary>
        /// Gibt einen Text auf der Konsole aus.
        /// </summary>
        /// <param name="str">Text, der ausgegeben werden soll</param>
        public static void Print(string str)
        {
            Console.WriteLine(str);
        }
    }
}
