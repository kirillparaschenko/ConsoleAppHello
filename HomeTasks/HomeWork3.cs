using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHello.HomeTasks
{
    internal class HomeWork3
    {
        /// <summary>
        /// 0. Создайте массив целых чисел. 
        /// Напишете программу, которая выводит сообщение о том, входит ли заданное число в массив или нет.
        /// Пусть число для поиска задается с консоли.
        /// </summary>
        public static void Task1()
        {
            int[] numbers = { 1, 22, -4, 25, 56, 17, 4, 34, 99 };
            
            Console.Write("Enter number: ");
            string? number = Console.ReadLine();
            int x = Convert.ToInt32(number);
            string result = "outside array";

            foreach (int i in numbers)
            {
                if (i == x)
                {
                   result = "in array";
                }
            }
            Console.Write($"{x} {result}");
        }
    }
}
