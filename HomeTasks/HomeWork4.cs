using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleAppHello.HomeTasks
{
    internal class HomeWork4
    {
        /// <summary>
        /// 1. Заменить в строке все вхождения 'test' на 'testing'. Удалить из текста все символы, являющиеся цифрами.
        /// </summary>
        public static void Task1() 
        {
            string s1 = "Smoke test, also1 called bui1ld verification 5 test or build acceptance test6";
            Regex regex = new Regex(@"\d");
            string target = "";
            string result = regex.Replace(s1, target);
            s1 = result.Replace("test", "testing");
            Console.WriteLine(s1);
        }

    }
}
