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

        /// <summary>
        /// 2. Используя метод вывода значения в консоль, выполните конкатенацию слов и выведите на экран следующую фразу:
        /// Welcome to the TMS lesons.
        /// Каждое слово должно быть записано отдельно и взято в кавычки, например "Welcome". Не забывайте о пробелах после каждого слова
        /// </summary>
        public static void Task2()
        {
            string word1 = "Welcome";
            string word2 = "to";
            string word3 = "the";
            string word4 = "TMS";
            string word5 = "lesons";

            Console.WriteLine($"\"{word1}\" \"{word2}\" \"{word3}\" \"{word4}\" \"{word5}\".");
        }

        /// <summary>
        /// 3. Дана строка: teamwithsomeofexcersicesabcwanttomakeitbetter.
        /// Необходимо найти в данной строке "abc", записав всё что до этих символов в первую переменную, а также всё, что после них во вторую.
        /// Результат вывести в консоль.
        /// </summary>
        public static void Task3()
        {
            string s1 = "teamwithsomeofexcersicesabcwanttomakeitbetter.";

            s1 = s1.Replace("abc", " ");
            string[] words = s1.Split(' ');

            string word1 = words[0];
            string word2 = words[1];

            Console.WriteLine($"{word1}\n{word2}");
        }

        /// <summary>
        /// Дана строка: Плохой день.
        /// Необходимо с помощью метода substring удалить слово "плохой".
        /// После чего необходимо используя команду insert создать строку со значением: Хороший день!!!!!!!!!.
        /// Заменить последний "!" на "?"
        /// </summary>
        public static void Task4()
        {
            string s1 = "Плохой день";

            s1 = s1.Substring(7);

            string substring = "Хороший ";
            s1 = s1.Insert(0, substring) + "!!!!!!!!!";

            int lasIindex = s1.LastIndexOf("!");
            s1 = s1.Remove(lasIindex) + "?";
           

            //Regex regex = new Regex(@"!$");
            //string result = regex.Replace(s1, "?");
            Console.WriteLine(s1);
        }
    }
}
