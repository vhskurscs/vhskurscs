using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBeispiel
{
    class Rechteck
    {
        public double A { get; set; }
        public double B { get; set; }

        public Rechteck() : this(0.0, 0.0)
        {
        }

        public Rechteck(double a, double b)
        {
            A = a;
            B = b;
        }

        public double Flaecheninhalt()
        {
            return A * B;
        }

        public double Umfang()
        {
            return 2 * (A + B);
        }
    }
}
