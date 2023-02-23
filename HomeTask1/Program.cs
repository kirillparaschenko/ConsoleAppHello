using System;
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
        /*Напишите программу определения, попадает ли указанное пользователем число от 0 до 100 в числовой промежуток[0 - 14][15 - 35][36 - 49][50 - 100].
Если да, то укажите, в какой именно промежуток.
Если пользователь указывает число, не входящее ни в один из имеющихся числовых промежутков, то выводится соответствующее сообщение.*/
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
    }
}

