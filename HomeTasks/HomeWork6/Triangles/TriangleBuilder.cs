using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHello.HomeTasks.HomeWork6.Triangles
{
    internal class TriangleBuilder
    {
        public TriangleBuilder() { }

        public Triangle CreateTriangle(double firstSide, double secondSide, double thirdSide)
        {
            if ((firstSide == secondSide) && (firstSide == thirdSide))
            {
                return new EquiletarlTriangle(firstSide, secondSide, thirdSide);
            }
            if (firstSide == secondSide | firstSide == thirdSide | secondSide == thirdSide)
            {
                return new IsoscelesTriangle(firstSide, secondSide, thirdSide);
            }
            if (Math.Pow(firstSide, 2) == (Math.Pow(secondSide, 2) + Math.Pow(thirdSide, 2)) | Math.Pow(secondSide, 2) == (Math.Pow(firstSide, 2) + Math.Pow(thirdSide, 2)) | Math.Pow(thirdSide, 2) == (Math.Pow(secondSide, 2) + Math.Pow(firstSide, 2)))
            {
                return new RightTriangle(firstSide, secondSide, thirdSide);
            }

            return new Triangle(firstSide, secondSide, thirdSide);
        }
    }
}
