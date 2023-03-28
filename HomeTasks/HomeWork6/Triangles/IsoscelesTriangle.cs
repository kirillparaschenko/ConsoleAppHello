using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHello.HomeTasks.HomeWork6.Triangles
{
    internal class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(double firstSide, double secondSide, double thirdSide) : base(firstSide, secondSide, thirdSide)
        {
        }

        public override double GetSquare()
        {
            if (firstSide == secondSide)
            {
                return GetSquare(thirdSide, firstSide);
            }
            if (secondSide == thirdSide)
            {
                return GetSquare(firstSide, thirdSide);
            }
            else
            {
                return GetSquare(secondSide, firstSide);
            }
        }

        private double GetSquare(double firstSide, double secondSide)
        {
            Console.WriteLine("Get square IsoscelesTriangle");
            return ((firstSide / 4) * Math.Sqrt(4 * Math.Pow(secondSide, 2) - Math.Pow(firstSide, 2)));
        }
    }
}
