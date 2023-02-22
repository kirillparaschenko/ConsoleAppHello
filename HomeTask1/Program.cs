using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lesson1_Task1();
        }
        public static void Lesson1_Task1() 
        {
            string name = Console.ReadLine();
            Console.WriteLine("Hello," + name + "!");
        }
    }
}

