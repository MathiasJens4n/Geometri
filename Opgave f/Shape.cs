using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_f
{
    internal class Shape
    {
        private double a;
        private double b;
        private double c;

        public double C
        {
            get { return c; }
            set { c = value; }
        }


        public double B
        {
            get { return b; }
            set { b = value; }
        }


        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public Shape(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public Shape(double a, double b)
        {
            A = a;
            B = b;
        }
        public virtual double CalcPerimeter()
        {
            double perimeter = 2 * (A + B);
            return perimeter;
        }
        public virtual double CalcArea()
        {
            double area = A * A;
            return area;
        }

    }
}
