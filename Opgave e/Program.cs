using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_e
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(4);
            Rectangle rectangle = new Rectangle(4);
            Trapeze trapeze = new Trapeze(10, 9 , 8);
            Parallelogram parallellogram = new Parallelogram(3, 5, 20);

            PrintToConsole(trapeze);
        }
        static void PrintToConsole(Trapeze trapeze)
        {
            Console.WriteLine(trapeze.CalcArea());
            Console.WriteLine(trapeze.CalcPerimeter());
        }
    }
}
