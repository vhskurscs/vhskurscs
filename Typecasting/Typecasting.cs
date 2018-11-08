using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typecasting
{
    class Typecasting
    {
        static void Main(string[] args)
        {
            //Ganzzahlentypen
            int intVal = 0;
            long longVal = 0;
            byte byteVal = 0;

            int meinInt = byteVal; //Implizite Konvertierung
            meinInt = (int)longVal; //Explizite Konvertierung
            byte meinByte = (byte)intVal;

            //Gleitkommatypen
            float floatVal = 12.123456f;
            double doubleVal = 0.0d;
            decimal decVal = 0.0m;

            float meinFloat = (float)doubleVal;
            double meinDouble = floatVal;
            decimal meinDec = (decimal)doubleVal;

            meinInt = (int)floatVal;

            Console.WriteLine("meinInt: " + meinInt.ToString());

            //Ausflug Operationen
            float op = (float)5 / 10;

            Console.WriteLine("op: " + op);

            //Cast bei Referenztypen
            object o = "Ich bin ein String in einem Object";
            object o1 = 5;
            string meinString = (string)o;
            meinString = o1 as string;

            object meinO = "Hallo";

            Console.ReadLine();
        }
    }
}
