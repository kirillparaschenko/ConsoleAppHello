using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHello.HomeTasks.HomeWork6
{
    internal class Figure
    {
        public double firstSide;
        public double secondSide;

        public virtual double GetSquare()
        {
            return firstSide * secondSide;
        }
    }
}
