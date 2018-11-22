using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektorientierung
{
    class Punkt
    {
        //Property/Eigenschaft X
        public int X { get; set; }
        public int Y { get; set; }

        public Punkt(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public Punkt(int val)
        {
            X = Y = val; //Kurzform für unten
        }

        public Punkt() : this(0)
        {
        }

        public virtual int Mult()
        {
            return X * Y;
        }

    }
}
