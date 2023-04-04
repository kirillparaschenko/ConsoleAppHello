using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleAppHello.HomeTasks.HomeWorkLINQ
{
    public class MethodsForStrings
    {
        /// <summary>
        /// возвращает первое слово из последовательности слов, содержащее только одну букву.
        /// </summary>
        /// <param name="sentence"></param>
        public static void GetFirstWordWithOneLetter(string sentence)
        {
            string[] words = sentence.Split(' ');
            var selectedWord = words.First(w => w.Length == 1);
            Console.WriteLine(selectedWord);
        }

        /// <summary>
        /// возвращающий последнее слово, содержащее в себе подстроку «ее». Реализовать, используя только 1 метод LINQ.
        /// </summary>
        /// <param name="sentence"></param>
        public static void GetLastWordEE(string sentence)
        {
            string[] words = sentence.Split(' ');

            Regex regex = new Regex(@"\w*ee\w*");
            var selectedWord = words.Last(w => regex.IsMatch(w)); 

            Console.WriteLine(selectedWord);
        }

        /// <summary>
        /// метод для возврата последнего слова, соответствующего условию: длина слова не меньше min и не больше max. 
        /// Если нет слов, соответствующих условию, метод возвращает null.
        /// </summary>
        /// <param name="sentence"></param>
        public static string GetLastWordWithParams(string sentence, int min, int max)
        {
            string[] words = sentence.Split(' ');

            var selectedWord = words.Last(w => w.Length >= min && w.Length <= max);
            if (selectedWord != null) 
            {
                return selectedWord;
                Console.WriteLine(selectedWord);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// возвращает количество уникальных значений в массиве.
        /// </summary>
        /// <param name="sentence"></param>
        public static void GetNumberOfUnickWords(string sentence)
        {
            string[] words = sentence.Split(' ');

            var selectedWords = words.Distinct();

            Console.WriteLine($"Number Of Unick Words: {selectedWords.Count()}");
        }

        /// <summary>
        /// принимает список и извлекает значения с 5  элемента (включительно)  те значения, которые содержат "3"
        /// </summary>
        /// <param name="words"></param>
        public static void GetElementsWith3(List<string> words)
        {
            Regex regex = new Regex(@"\w*3\w*");

            var selectedWords = from w in words.Skip(5) where regex.IsMatch(w) select w; 

            foreach (var selectedWord in selectedWords)
            {
                Console.WriteLine(selectedWord);
            }
        }

        /// <summary>
        /// возвращает длину самого короткого слова
        /// </summary>
        /// <param name="words"></param>
        public static void GetSmallestWord(List<string> words)
        {
            var selectedWords = from w in words orderby w.Length select w;

            Console.WriteLine($"Smallest word: {selectedWords.ElementAt(0)}");
        }

        /// <summary>
        /// преобразует словарь в список и меняет местами каждый ключ и значение
        /// </summary>
        /// <param name="words"></param>
        public static void ConvertDictonary(Dictionary<int, string> words)
        {
            var newListValues = from w in words.Values select w;
            var newListKeys = from w in words.Keys select w;

            var newList = newListValues.Zip(newListKeys);

            foreach (var word in newList)
            {
                Console.WriteLine(word);
            }
        }
    }
}
