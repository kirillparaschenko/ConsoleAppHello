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
        public static void Task0()
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

        /// <summary>
        /// 1. Создайте массив целых чисел. Удалите все вхождения заданного числа из массива.
        /// Пусть число задается с консоли.Если такого числа нет - выведите сообщения об этом.
        /// В результате должен быть новый массив без указанного числа. 
        /// </summary>
        //public static void Task1()
        //{
        //    int[] numbers = { 1, 22, -4, 25, 56, 17, 4, 34, 99 };

        //    Console.Write("Enter number: ");
        //    string? number = Console.ReadLine();
        //    int x = Convert.ToInt32(number);

        //    foreach (int i in numbers)
        //    {
        //        if (i != x)
        //        {
        //            Console.WriteLine($"{number} outside array");
        //        }
        //    }
        //}

        /// <summary>
        /// 2. Создайте и заполните массив случайным числами и выведете максимальное, минимальное и среднее значение.
        /// Для генерации случайного числа используйте метод Random().
        /// Пусть будет возможность создавать массив произвольного размера.Пусть размер массива вводится с консоли.
        /// </summary>
        public static void Task2() 
        {
            Console.Write("Enter array capacity: ");
            string? capacity = Console.ReadLine();
            int n = Convert.ToInt32(capacity);

            Random random = new Random();
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = (int)random.NextInt64(0, 100);
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            int maxNumber = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");

            int minNumber = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < maxNumber)
                {
                    minNumber = numbers[i];
                }
            }
            Console.WriteLine($"Min number: {minNumber}");

            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            double average = sum / n;
            Console.WriteLine($"Average value: {average}");

        }


    }
}
