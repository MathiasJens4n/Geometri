using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_d
{
    internal class Parallelogram : Square
    {
        private double v;

        public double V
        {
            get { return v; }
            set { v = value; }
        }

        public Parallelogram(double a, double b, double v) : base(a, b)
        {
            V = v;
        }
        public override double CalcArea()
        {
            double area = A * B * Math.Sin(V);
            return area;
        }

    }
}
