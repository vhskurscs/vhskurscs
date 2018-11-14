using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektorientierung
{
    class Program
    {
        static void Main(string[] args)
        {
            Punkt p = new Punkt(1, 2);

            Punkt p2 = new Punkt(12, 13);

            Punkt p3 = p;

            Punkt p4 = new Punkt();

            #region Referenzbeispiele
            //Console.WriteLine("p.x = " + p.x);
            //Console.WriteLine("p.y = " + p.y);

            //Console.WriteLine("p2.x = " + p2.x);
            //Console.WriteLine("p2.y = " + p2.y);

            //Console.WriteLine("p3.x = " + p3.x);
            //Console.WriteLine("p3.y = " + p3.y);

            //Console.WriteLine();
            //Console.WriteLine("Verändere p3 x und y");
            //p3.x = 100;
            //p3.y = 200;

            //Console.WriteLine();

            //Console.WriteLine("p.x = " + p.x);
            //Console.WriteLine("p.y = " + p.y);

            //Console.WriteLine("p2.x = " + p2.x);
            //Console.WriteLine("p2.y = " + p2.y);

            //Console.WriteLine("p3.x = " + p3.x);
            //Console.WriteLine("p3.y = " + p3.y);

            //Console.WriteLine();
            //Console.WriteLine("Jetzt ändern wird p in einer Methode");
            //Console.WriteLine();

            //Program.MachWas(p);

            //Console.WriteLine("p.x = " + p.x);
            //Console.WriteLine("p.y = " + p.y);

            //Console.WriteLine("p2.x = " + p2.x);
            //Console.WriteLine("p2.y = " + p2.y);

            //Console.WriteLine("p3.x = " + p3.x);
            //Console.WriteLine("p3.y = " + p3.y);
            #endregion

            int mult = p.Mult();


            Console.WriteLine("p.Mult(): " + mult);
            Console.WriteLine("p2.Mult(): " + p2.Mult());
            Console.WriteLine("p3.Mult(): " + p3.Mult());

            Console.WriteLine("p.X: " + p.X);
            p.X = -100;
            Console.WriteLine("p.X: " + p.X);
        }

        //public static void MachWas(Punkt p)
        //{
        //    p.x = 900;
        //    p.y = 8000;
        //}
    }
}
