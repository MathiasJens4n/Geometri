using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_f
{
    internal class Rectangle : Shape
    {

        public Rectangle(double a, double b) : base(a, b)
        {

        }
        public override double CalcArea()
        {
            double area = A * B;
            return area;
        }
    }
}
