using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHello.HomeTasks.HomeWork6.Rectangles
{
    internal class Square : Rectangle
    {
        public Square(double firstSide, double secondSide) : base(firstSide, secondSide)
        {
        }

        public override double GetSquare()
        {
            Console.WriteLine("Get square Square");
            return Math.Pow(firstSide, 2);
        }
    }
}
