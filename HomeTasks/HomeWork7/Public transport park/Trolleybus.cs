using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHello.HomeTasks.HomeWork7.Public_transport_park
{
    internal class Trolleybus : Transport
    {
        public Trolleybus(string number, string endStation, string departureTime, int seats) : base(number, endStation, departureTime, seats)
        {
        }

        public override string Number { get; set; }
        public override string EndStation { get; set; }
        public override string DepartureTime { get; set; }
        public override int Seats { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"Trolleybus: {Number}, {DepartureTime}, {EndStation}, {Seats}");
        }

        public override void TransportType()
        {
            Console.WriteLine("Electric Trolleybus");
        }
    }
}
