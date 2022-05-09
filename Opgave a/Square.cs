using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_a
{
    internal class Square
    {
        double a = 90;
        public Square(double a)
        {
            this.a = a;
        }
        public double CalcPerimeter()
        {
            double perimeter = a + a + a + a;
            return perimeter;
        }
        public double CalcArea()
        {
            double area = a * a;
            return area;
        }
    }
}
