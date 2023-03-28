using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHello.HomeTasks.HomeWork9
{
    /// <summary>
    /// 3. Реализовать обобщенный класс Point , который определяет точку на координатной плоскости.
    /// В классе реализовать:
    /// обобщенные внутренние поля x, y;
    /// конструктор с 2 параметрами;
    /// свойства доступа к внутренним полям класса;
    /// метод, выводящий значения внутренних полей класса;
    /// метод нахождения расстояния с другой точкой
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Point<T> where T: struct
    {
        public T X { get; set; }
        public T Y { get; set; }
        public Point(T x, T y) 
        {
            this.X = x;
            this.Y = y;
        }

        public void GetPoint()
        {
            Console.WriteLine($"x = {X}, y = {Y}");
        }

        public static double Distance(Point<double> p1, Point<double> p2)
        {
            double result;
            result = Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
            Console.WriteLine($"Distance between Point 1 and Point 2: {result}");
            return result;
        }
    }
}
