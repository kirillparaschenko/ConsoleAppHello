﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHello.HomeTasks.HomeWork7.Public_transport_park
{
    internal class Bus : Transport, ITransportService
    {
        public Bus(string number, string endStation, string departureTime, int seats) : base(number, endStation, departureTime, seats)
        {
        }

        public override string Number { get; set; }
        public override string EndStation { get; set; }
        public override string DepartureTime { get; set; }
        public override int Seats { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"Bus: {Number}, {DepartureTime}, {EndStation}, {Seats}");
        }

        public override void TransportType()
        {
            Console.WriteLine("Diesel Bus");
        }
    }
}
