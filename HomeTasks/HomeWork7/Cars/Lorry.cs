using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHello.HomeTasks.HomeWork7.Cars
{
    internal class Lorry : Auto
    {
        private readonly bool isTrailer;
        public Lorry(string model, string number, int speed, int сarrying, bool isTrailer) : base(model, number, speed, сarrying)
        {
            this.isTrailer = isTrailer;
            Carrying = CalculateCarrying();
        }

        public override string Model { get; set; }
        public override string Number { get; set; }
        public override int Speed { get; set; }
        public override int Carrying { get; set; }

        public override int CalculateCarrying()
        {
            if (isTrailer)
            {
                return Carrying * 2;
            }
            else return Carrying;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Lorry: {Model}, Number: {Number}, Speed: {Speed}, Carrying: {Carrying}, Trailer: {isTrailer}");
        }
    }
}
