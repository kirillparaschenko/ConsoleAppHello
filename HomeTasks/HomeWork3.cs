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
            Console.WriteLine($"{x} {result}");
        }

        /// <summary>
        /// 1. Создайте массив целых чисел. Удалите все вхождения заданного числа из массива.
        /// Пусть число задается с консоли.Если такого числа нет - выведите сообщения об этом.
        /// В результате должен быть новый массив без указанного числа. 
        /// </summary>
        public static void Task1()
        {
            int[] numbers1 = new int [9]{ 1, 22, 4, 25, 56, 17, 4, 34, 99 };

            Console.Write("Enter number: ");
            string? number = Console.ReadLine();
            int x = Convert.ToInt32(number);
            int countOfnumber = 0;

            foreach (int i in numbers1)
            {
                if (i == x)
                {
                    countOfnumber++;
                }
            }

            if (countOfnumber > 0)
            {
                int[] numbers2 = new int[9 - countOfnumber];

                for (int i = 0, j = 0; i < numbers1.Length; i++)
                {
                    if (numbers1[i] != x)
                    {
                        numbers2[j] = numbers1[i];
                        Console.Write(numbers2[j++] + " ");
                    }
                }
                Console.WriteLine();
            }
            else 
            {
                Console.WriteLine($"{x} outside array");
            };
        }

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

        /// <summary>
        /// 3. Создайте 2 массива из 5 чисел. Выведите массивы на консоль в двух отдельных строках.
        /// Посчитайте среднее арифметическое элементов каждого массива и сообщите,
        /// для какого из массивов это значение оказалось больше (либо сообщите, что их средние арифметические равны).  
        /// </summary>
        public static void Task3()
        {
            Console.WriteLine("Task3");
            Random random = new Random();
            int[] array1 = new int[5];
            int[] array2 = new int[5];

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = (int)random.NextInt64(0, 100);
                Console.Write(array1[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = (int)random.NextInt64(0, 100);
                Console.Write(array2[i] + " ");
            }
            Console.WriteLine();

            double sum1 = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                sum1 += array1[i];
            }

            double average1 = sum1 / 5;

            double sum2 = 0;
            for (int i = 0; i < array2.Length; i++)
            {
                sum2 += array2[i];
            }

            double average2 = sum2 / 5;

            if (average1 > average2) 
            {
                Console.WriteLine($"Average value of Array1 {average1} > {average2} Average value of Array2");
            }
            else if (average1 < average2 )
            {
                Console.WriteLine($"Average value of Array1 {average1} < {average2} Average value of Array2");
            }
            else 
            {
                Console.WriteLine($"Average value of Array1 {average1} = {average2} Average value of Array2");
            }
        }
    }
}
