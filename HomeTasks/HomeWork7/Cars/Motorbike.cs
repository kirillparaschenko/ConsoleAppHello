using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHello.HomeTasks.HomeWork7.Cars
{
    internal class Motorbike : Auto
    {
        public bool IfHaveWheelchair;
        public Motorbike(string model, string number, int speed, int сarrying, bool ifhavewheelchair) : base(model, number, speed, сarrying)
        {
            IfHaveWheelchair = ifhavewheelchair;
            Carrying = CalculateCarrying();
        }

        public override string Model { get; set; }
        public override string Number { get; set; }
        public override int Speed { get; set; }
        public override int Carrying { get; set; }

        public override int CalculateCarrying()
        {
            if (IfHaveWheelchair == false) 
            {
                return 0;
            }
            else return Carrying;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Motorbike: {Model}, Number: {Number}, Speed: {Speed}, Carrying: {Carrying}, Wheelchair: {IfHaveWheelchair}");
        }
    }
}
