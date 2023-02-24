using System;
using System.Transactions;
using System.Xml.Linq;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lesson1_Task1();
            Lesson2_Task1_Calculator();
            Lesson2_Task2_RangeDetermination();
            Lesson2_Task3_RangeDetermination();
            Lesson2_Task4_ParityCheck();
            Lesson2_Task4_1_ParityCheck();
        }
        public static void Lesson1_Task1()
        {
            string? name = Console.ReadLine();
            Console.WriteLine("Hello," + name + "!");
        }
        public static void Lesson2_Task1_Calculator()
        {
            double operand1 = 10.123;
            double operand2 = 6.789;
            double result = 0;
            Console.Write("Enter sign (+,-,*,/): ");
            string? sign = Console.ReadLine();
            switch (sign)
            {
                case "+":
                    result = operand1 + operand2;
                    break;
                case "-":
                    result = operand1 - operand2;
                    break;
                case "*":
                    result = operand1 * operand2;
                    break;
                case "/":
                    if (operand2 == 0)
                    {
                        Console.WriteLine($"Division by 0 is not allowed");
                        return;
                    }
                    else
                    {
                        result = operand1 / operand2;
                    }
                    break;
            }
            Console.WriteLine($"{operand1} {sign} {operand2} = {result}");
        }
        public static void Lesson2_Task2_RangeDetermination()
        {
            Console.Write("Enter number: ");
            string? number = Console.ReadLine();
            double x = Convert.ToDouble(number);
            if (x >= 0 && x <= 14)
            {
                Console.WriteLine($"{number} in Range [0 - 14]");
            }
            else if (x >= 15 && x <= 35)
            {
                Console.WriteLine($"{number} in Range [15 - 35]");
            }
            else if (x >= 36 && x <= 49)
            {
                Console.WriteLine($"{number} in Range [36 - 49]");
            }
            else if (x >= 50 && x <= 100)
            {
                Console.WriteLine($"{number} in Range [50 - 100]");
            }
            else { Console.WriteLine($"{number} out of Range [0 - 100]"); }
        }
        public static void Lesson2_Task3_RangeDetermination()
        {
            Console.Write("Введите слово: ");
            string? word = Console.ReadLine();

            string translation = word switch
            {
                "холодно" => "cold",
                "тепло" => "warm",
                "жарко" => "hot",
                "морозно" => "frosty",
                "солнечно" => "sunny",
                "ясно" => "clear",
                "душно" => "stuffy",
                "облачно" => "cloudy",
                "ветренно" => "windy",
                "сухо" => "dry",
                _ => "Отсутствует в словаре"
            };
            Console.WriteLine($"{translation}");
        }

        public static void Lesson2_Task4_ParityCheck()
        {
            Console.Write("Enter a whole number: ");
            string? number = Console.ReadLine();
            int x = Convert.ToInt32(number);
            if (x % 2 == 0) 
            {
                Console.WriteLine($"{number} is even");
            }
            else
            {
                Console.WriteLine($"{number} is odd");
            }
        }

        public static void Lesson2_Task4_1_ParityCheck()
        {
            Console.Write("Entera whole number: ");
            string? number = Console.ReadLine();
            double x = Convert.ToDouble(number);
            double y = ((x / 2) * x);

            if (y == Math.Round(y, 0))
            {
                Console.WriteLine($"{number} is even");
            }
            else
            {
                Console.WriteLine($"{number} is odd");
            }
        }
    }
}

