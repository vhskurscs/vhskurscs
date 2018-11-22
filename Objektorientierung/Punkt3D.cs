using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektorientierung
{
    class Punkt3D : Punkt
    {
        public int Z { get; set; }

        public Punkt3D(int x, int y, int z) : base(x, y)
        {
            this.Z = z;
        }

        public Punkt3D() : this(0, 0, 0) { }

        public override int Mult()
        {
            return base.Mult() * Z;
        }
    }
}
