using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHello.HomeTasks.HomeWork7.Public_transport_park
{
    public abstract class Transport : IComparable<Transport>, ITransportService
    {
        public abstract string Number { get; set; }
        public abstract string EndStation { get; set; }
        public abstract string DepartureTime { get; set;}
        public abstract int Seats { get; set;}

        public Transport(string number, string endStation, string departureTime, int seats) 
        {
            Number = number;
            EndStation = endStation;
            DepartureTime = departureTime;
            Seats = seats;
        }

        public abstract void TransportType();
        public abstract void GetInfo();

        public int CompareTo(Transport? transport)
        {
            return Seats - transport.Seats;
        }

        public void PrintTransportType(Transport transport)
        {
            transport.GetInfo();
        }
    }
}
