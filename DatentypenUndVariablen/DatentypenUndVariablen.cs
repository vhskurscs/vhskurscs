using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatentypenUndVariablen
{
    class DatentypenUndVariablen
    {
        static void Main(string[] args)
        {
            //Variablen allgemein
            int meineZahl; //Deklaration
            meineZahl = 42; //Initialisierung
            meineZahl = 12; //Wertzuweisung

            int meineZahl1 = 300; //Definition
            meineZahl1 = 100;

            //Datentypen und Wertebereiche
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;

            Console.WriteLine("MaxInt: " + maxInt);
            Console.WriteLine("MinInt: " + minInt);

            int intOverflow = maxInt + 1;

            Console.WriteLine("itnOverflow: " + intOverflow);

            long meinLong = 0;
            int mInt = (int)meinLong;

            //Ganzzahlige Datentypen
            byte byteMax = byte.MaxValue;
            byte byteMin = byte.MinValue;

            short shortMax = short.MaxValue;
            short shortMin = short.MinValue;

            long longMax = long.MaxValue;
            long longMin = long.MinValue;

            uint uintMax = uint.MaxValue;
            uint uintMin = uint.MinValue;

            char charVal = 'A';

            Console.WriteLine("Byte");
            Console.WriteLine(byteMax);
            Console.WriteLine(byteMin);
            Console.WriteLine("Short");
            Console.WriteLine(shortMax);
            Console.WriteLine(shortMin);
            Console.WriteLine("Long");
            Console.WriteLine(longMax);
            Console.WriteLine(longMin);
            Console.WriteLine("uint");
            Console.WriteLine(uintMax);
            Console.WriteLine(uintMin);
            Console.WriteLine("char");
            Console.WriteLine(charVal);

            //Gleitkommatypen
            float floatVal = 1.5f;
            double doubleVal = 2.5d;
            decimal decimalVal = 3.5m;

            Console.WriteLine("Gleitkommazahlen");
            Console.WriteLine("float: " + floatVal);
            Console.WriteLine("double: " + doubleVal);

            //Wahrheitstyp
            bool boolFalse = false;
            bool boolTrue = true;

            Console.WriteLine(boolFalse);

            //Referenztypen
            string stringVal = "Hallo \tich bin \neine \"Zeichenkette\"!";
            string path = @"C:\Users\vhs\Desktop\file.txt";
            Console.WriteLine("String");
            Console.WriteLine(stringVal);
            Console.WriteLine(path);

            //Mutter aller Datentypen
            object o = 1;
            object o1 = "Ein String";
            object o2 = false;

            int meinInt = (int)o;

            Console.WriteLine("object");
            Console.WriteLine(o);
            Console.WriteLine(o1);
            Console.WriteLine(o2);

            //Null-Wert
            object nullObject = null;


            //Fenster soll nicht sofort schließen
            Console.ReadLine();
        }
    }
}
