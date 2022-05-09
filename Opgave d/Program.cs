using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(4);
            Rectangle rectangle = new Rectangle(4);
            Trapeze trapeze = new Trapeze(4);
            Parallelogram parallellogram = new Parallelogram(3, 5, 20);

            PrintToConsole(parallellogram);
        }
        static void PrintToConsole(Parallelogram parallelogram)
        {
            Console.WriteLine(parallelogram.CalcArea());
            Console.WriteLine(parallelogram.CalcPerimeter());
        }
    }
}
