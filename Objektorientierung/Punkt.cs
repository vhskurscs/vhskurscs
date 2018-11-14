using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektorientierung
{
    class Punkt
    {
        //Member-Variablen
        private int x;
        //Property/Eigenschaft X
        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                if (value < 0)
                    this.x = 0;
                else
                    this.x = value;
            }
        }

        private int y;

        public Punkt(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Punkt(int val)
        {
            x = y = val; //Kurzform für unten
            //x = val;
            //y = val;
        }

        public Punkt() : this(0)
        {
        }

        public int Mult()
        {
            return x * y;
        }

    }
}
