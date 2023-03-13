using ConsoleAppHello.HomeTasks.HomeWork7.Cars;
using ConsoleAppHello.HomeTasks.HomeWork7.Public_transport_park;
using ConsoleAppHello.HomeTasks.HomeWork6;
using ConsoleAppHello.HomeTasks.HomeWork6.Clinica;
using ConsoleAppHello.HomeTasks.HomeWork6.Rectangles;
using ConsoleAppHello.HomeTasks.HomeWork6.Triangles;
using System;
using System.Transactions;
using System.Xml.Linq;

namespace ConsoleAppHello.HomeTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1 создавь массив квадратов, прямоугольник и треугольников и вывести их площади

            Figure triangle1 = new TriangleBuilder().CreateTriangle(7, 6, 8);
            Figure triangle2 = new TriangleBuilder().CreateTriangle(3, 3, 3);
            Figure triangle3 = new TriangleBuilder().CreateTriangle(4, 4, 2);
            Figure triangle4 = new TriangleBuilder().CreateTriangle(3, 4, 5);
            Figure rectangle1 = new Rectangle(5, 6);
            Figure square1 = new Square(6, 6);

            Figure[] figures = new Figure[] { triangle1, triangle2, triangle3, triangle4, rectangle1, square1 };
            foreach (var obj in figures) 
            {
                double square = obj.GetSquare();
                Console.WriteLine(square);
            }

            //Task 2
            //Создать объект класса «Пациент» и добавить пациенту план лечения.
            //Также создать метод, который будет назначать врача пациенту согласно  плану лечения.

            Patient patient1 = new Patient("Ivan");
            TreatmentPlan plan1 = new TreatmentPlan (patient1, 1);
            plan1.AsignDoctor();

            //Task 3
            //В классе с main методом создать массив объектов из различных видов транспорта.
            //Провести сортировку транспорта по количеству мест и вывести данные объектов в консоль.
            //Запросить у пользователя время отправления и/ или пункт назначения. Найти в массиве объект, соответствующий заданным параметрам, и вывести его данные в консоль.
            //Запросить у пользователя время отправления.Вывести в консоль список транспорта, отправляющегося после заданного времени.
            //вызвать метод printTransportType несколько раз, передавая ему как параметр объекты классов наследников (Bus, Trolleybus и т.д.)

            var bus = new Bus("1", "Station 1", "11.03.2023 00:00:00", 40);
            var routetaxi = new RouteTaxi("20", "Station 2", "11.03.2023 00:01:00", 16);
            var trollebus = new Trolleybus("3", "Station 3", "11.03.2023 00:02:00", 30);
            var tramcar = new Tramcar("4", "Station 4", "11.03.2023 00:03:00", 25);

            Transport[] transports = new Transport[] { bus, routetaxi, trollebus, tramcar };
            Array.Sort(transports);

            foreach (var transport in transports)
            {
                transport.GetInfo();
            }

            Console.Write("Enter End Station:");
            string requiredEndStation = Console.ReadLine();

            foreach (var transport in transports)
            {
                if (requiredEndStation == transport.EndStation)
                {
                    transport.GetInfo();
                }
            }

            Console.Write("Enter DepartureTime in format mm.dd.yyyy hh:mm:ss -");
            string requiredDepartureTime = Console.ReadLine();
            DateTime requiredTime = DateTime.Parse(requiredDepartureTime);

            foreach (var transport in transports)
            {
                DateTime departureTime = DateTime.Parse(transport.DepartureTime);
                if (departureTime >= requiredTime)
                {
                    transport.GetInfo();
                }
            }

            //Task 4
            //Создать базу (массив) из n машин, вывести полную информацию из базы на экран,
            //а также организовать поиск машин, удовлетворяющих требованиям грузоподъемности.

            var car = new PassengerCar("BMW", "12256", 200, 300);
            var motorbike = new Motorbike("Honda", "2222", 250, 10, false);
            var lorry = new Lorry("MAN", "33333", 120, 1000, true);

            Auto[] autos = new Auto[] { car, motorbike, lorry };
            foreach (var auto in autos)
            {
                auto.GetInfo();
            }

            Console.Write("Enter required carrying, kg: ");
            int requriedCarrying = int.Parse(Console.ReadLine());
            foreach (var auto in autos)
            {
                if (requriedCarrying <= auto.Carrying)
                {
                    auto.GetInfo();
                }
            }

        }
    }
}

