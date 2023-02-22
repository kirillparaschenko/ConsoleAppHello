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
        }
        public static void Lesson1_Task1()
        {
            string name = Console.ReadLine();
            Console.WriteLine("Hello," + name + "!");
        }
        public static void Lesson2_Task1_Calculator()
        {
            double operand1 = 10;
            double operand2 = 6;
            double result = 0;
            Console.Write("Enter sign: ");
            string sign = Console.ReadLine();
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
    }
}

