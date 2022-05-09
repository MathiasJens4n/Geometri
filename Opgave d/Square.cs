using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_d
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
        public Square(double a, double b)
        {
            A = a;
            B = b;
        }
        public virtual double CalcPerimeter()
        {
            double perimeter = A + A + A + A;
            return perimeter;
        }
        public virtual double CalcArea()
        {
            double area = A * A;
            return area;
        }
    }
}
