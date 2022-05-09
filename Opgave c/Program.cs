using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(4);
            Rectangle rectangle = new Rectangle(4);
            Trapeze trapeze = new Trapeze(4);
            Parallelogram parallellogram = new Parallelogram(4);

            PrintToConsole(square);
        }
        static void PrintToConsole(Square sqare)
        {
            Console.WriteLine(sqare.CalcArea());
            Console.WriteLine(sqare.CalcPerimeter());
        }
    }
}
