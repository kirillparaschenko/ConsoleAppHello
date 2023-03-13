using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHello.HomeTasks.HomeWork7.Cars
{
    internal class PassengerCar : Auto
    {
        public PassengerCar(string model, string number, int speed, int сarrying) : base(model, number, speed, сarrying)
        {
        }

        public override string Model { get; set; }
        public override string Number { get; set; }
        public override int Speed { get; set; }
        public override int Carrying { get; set; }

        public override int CalculateCarrying()
        {
            return Carrying;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Passenger Car: {Model}, Number: {Number}, Speed: {Speed}, Carrying: {Carrying}");
        }
    }
}
