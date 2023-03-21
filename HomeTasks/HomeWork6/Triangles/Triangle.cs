using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHello.HomeTasks.HomeWork6.Triangles
{
    internal class Triangle : Figure
    {
        public double thirdSide;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;
        }

        public override double GetSquare()
        {
            Console.WriteLine("Get square Heron formula");
            double semiPerimetr = (double)((firstSide + secondSide + thirdSide) / 2);
            return Math.Sqrt(semiPerimetr * (semiPerimetr - firstSide) * (semiPerimetr - secondSide) * (semiPerimetr - thirdSide));
        }

    }
}
