using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_a
{
    internal class Square
    {
        private double a;
        private double b;

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

        public Square(double a)
        {
            A = a;
        }
        public double CalcPerimeter()
        {
            double perimeter = 2 * (A + B);
            return perimeter;
        }
        public double CalcArea()
        {
            double area = A * A;
            return area;
        }
    }
}
