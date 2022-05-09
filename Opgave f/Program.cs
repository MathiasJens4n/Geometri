using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_f
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(4, 4);
            Rectangle rectangle = new Rectangle(4, 4);
            Trapeze trapeze = new Trapeze(10, 9 , 8);
            Parallelogram parallellogram = new Parallelogram(3, 5, 20);
            Triangle triangle = new Triangle(4, 4, 4);

            PrintToConsole(triangle);
        }
        static void PrintToConsole(Triangle triangle)
        {
            Console.WriteLine(triangle.CalcArea());
            Console.WriteLine(triangle.CalcPerimeter());
        }
    }
}
