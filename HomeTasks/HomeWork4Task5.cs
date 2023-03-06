using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleAppHello.HomeTasks
{
    /// <summary>
    /// 5. Написать программу со следующим функционалом:
    /// На вход передать строку(будем считать, что это номер документа).
    /// Номер документа имеет формат xxxx-yyy-xxxx-yyy-xyxy, где x — это число,а y — это буква.
    /// </summary>
    internal class HomeWork4Task5
    {
        /// <summary>
        /// - Вывести на экран в одну строку два первых блока по 4 цифры.
        /// Все эти методы реализовать в отдельном классе в статических методах,
        /// которые на вход(входным параметром) будут принимать вводимую на вход программы строку.
        /// </summary>
        public static void Task5_1()
        {
            string doc_number = "1212-asd-4545-zxc-7q8w";

            string[] numbers = doc_number.Split('-');
            string pattern = @"\d\d\d\d";
            foreach (string number in numbers)
            {
                if (Regex.IsMatch(number, pattern, RegexOptions.IgnoreCase))
                Console.Write(number + " ");
            }
        }

        /// <summary>
        /// - Вывести на экран номер документа, но блоки из трех букв заменить на*** (каждая буква заменятся на*).
        /// </summary>
        public static void Task5_2()
        {
            string doc_number = "1212-asd-4545-zxc-7q8w";

            Regex regex = new Regex(@"-\D\D\D-");
            string target = "-***-";
            string result = regex.Replace(doc_number, target);

            Console.WriteLine(result);
        }

        /// <summary>
        /// - Вывести на экран только одни буквы из номера документа в формате yyy/yyy/y/y в нижнем регистре.
        /// </summary>
        //public static void Task5_3()
        //{
        //    string doc_number = "1212-Asd-4545-zXc-7q8W";

        //    doc_number = doc_number.Replace("-","/");

        //    Regex regex = new Regex(@"\d");
        //    string target = "";
        //    string result = regex.Replace(doc_number, target);

        //    string[] letters = result.Split("/");
            
        //    foreach (string letter in letters) 
        //    {
        //        Console.Write(letter);
        //    }
        //}
    }
}
