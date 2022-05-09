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

            List<Shape> shapes = new List<Shape>() {
            square,
            rectangle,
            trapeze,
            parallellogram,
            triangle
            };

            PrintToConsole(shapes);


        }
        static void PrintToConsole(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                Console.WriteLine($"--------- {shape.GetType().Name} ---------"); 
                Console.WriteLine($"Areal: {shape.CalcArea()}");
                Console.WriteLine($"Perimeter: {shape.CalcPerimeter()}");
            }
        }
    }
}
