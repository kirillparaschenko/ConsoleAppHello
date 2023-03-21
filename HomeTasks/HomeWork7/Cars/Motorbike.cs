using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHello.HomeTasks.HomeWork7.Cars
{
    internal class Motorbike : Auto
    {
        private readonly bool isWheelchair;
        public Motorbike(string model, string number, int speed, int сarrying, bool iswheelchair) : base(model, number, speed, сarrying)
        {
            this.isWheelchair = iswheelchair;
            Carrying = CalculateCarrying();
        }

        public override string Model { get; set; }
        public override string Number { get; set; }
        public override int Speed { get; set; }
        public override int Carrying { get; set; }

        public override int CalculateCarrying()
        {
            var result = !isWheelchair ? 0 : Carrying;
            return result;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Motorbike: {Model}, Number: {Number}, Speed: {Speed}, Carrying: {Carrying}, Wheelchair: {isWheelchair}");
        }
    }
}
