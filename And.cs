using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redNeuronal
{
    class And
    {
        public double Entrada1 { get; set; }
        public double Entrada2 { get; set; }
        public double Entrada3 { get; set; }
        public double Salidax { get; set; }

        public And(double x1, double x2, double x3, double dx)
        {
            this.Entrada1 = x1;
            this.Entrada2 = x2;
            this.Entrada3 = x3;
            this.Salidax = dx;

        }
    }
}
