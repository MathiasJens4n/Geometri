using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_f
{
    internal class Square : Shape
    {
        public Square(double A, double B) : base(A, B)
        {

        }
        public override double CalcArea()
        {
            double area = A * B;
            return area;
        }
    }
}
