using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_f
{
    internal class Triangle : Shape
    {
        public Triangle(double a, double b, double c) : base(a, b, c)
        {

        }
        public override double CalcArea()
        {
            double area = 0.5 * A * B;
            return area;
        }
        public override double CalcPerimeter()
        {
            double perimeter = A + B + C;
            return perimeter;
        }
    }
}
