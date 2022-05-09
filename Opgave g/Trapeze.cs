using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_f
{
    internal class Trapeze : Shape
    {
        private double d;
        private double s;
        private double h;

        public double D
        {
            get { return d; }
            set { d = value; }
        }


        public Trapeze(double a, double b, double c) : base(a, b, c)
        {
            d = b;
        }
        public override double CalcArea()
        {
            s = (A + B - C + D) / 2;
            h = 2 / (A - C) * Math.Sqrt(s * (s - A + C) * (s - B) * (s - D));
            double area = 0.5 * (A + C) * h;
            return area;
        }
    }
}
