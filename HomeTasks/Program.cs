using ConsoleAppHello.HomeTasks.HomeWork7.Cars;
using ConsoleAppHello.HomeTasks.HomeWork7.Public_transport_park;
using ConsoleAppHello.HomeTasks.HomeWork6;
using ConsoleAppHello.HomeTasks.HomeWork6.Clinica;
using ConsoleAppHello.HomeTasks.HomeWork6.Rectangles;
using ConsoleAppHello.HomeTasks.HomeWork6.Triangles;
using ConsoleAppHello.HomeTasks.HomeWork7;
using System;
using System.Transactions;
using System.Xml.Linq;
using ConsoleAppHello.HomeTasks.HomeWork9;
using ConsoleAppHello.HomeTasks.HomeWork9.Machines;

namespace ConsoleAppHello.HomeTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task2
            var polo = new Machine<GasMotor>(new GasMotor());
            polo.Move();
            polo.Refuel();

            //Task3
            var point1 = new Point<double>(12, 15);
            var point2 = new Point<double>(25, 30);
            point1.GetPoint();
            point2.GetPoint();
            Point<double>.Distance(point1, point2);
        }
    }
}

