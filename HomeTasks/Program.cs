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

        }
    }
}

