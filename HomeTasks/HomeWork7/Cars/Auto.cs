using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHello.HomeTasks.HomeWork7.Cars
{
    internal abstract class Auto
    {
        public abstract string Model { get; set; }
        public abstract string Number { get; set; }
        public abstract int Speed { get; set; }
        public abstract int Carrying { get; set; }

        public Auto(string model, string number, int speed, int сarrying)
        {
            Model = model;
            Number = number;
            Speed = speed;
            Carrying = сarrying;
        }

        public abstract void GetInfo();
        public abstract int CalculateCarrying();
    }
}
