using ConsoleAppHello.HomeTasks.HomeWork8;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ConsoleAppHello.HomeTasks.HomeWork7.Cars;
using ConsoleAppHello.HomeTasks.HomeWork7.Public_transport_park;
using ConsoleAppHello.HomeTasks.HomeWork6;
using ConsoleAppHello.HomeTasks.HomeWork6.Clinica;
using ConsoleAppHello.HomeTasks.HomeWork6.Rectangles;
using ConsoleAppHello.HomeTasks.HomeWork6.Triangles;
using ConsoleAppHello.HomeTasks.HomeWork7;
using System;
using System.Transactions;
using System.Xml.Linq;
using ConsoleAppHello.HomeTasks.HomeWork9;
using ConsoleAppHello.HomeTasks.HomeWork9.Machines;
using ConsoleAppHello.HomeTasks.HomeWorkLINQ;

namespace ConsoleAppHello.HomeTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var users = new List<User>
            {
                new User("Иван", "Иванович", "Иванов"),
                new User("Кирилл", "", "Кириллов"),
                new User("Петр", "Петрович", "Петров")
            };

            User.GetFullName(users);
            User.OrderUsersByLastName(users);

            string sentence = "sadf ee as ee d fgees a dfgsdf";

            MethodsForStrings.GetFirstWordWithOneLetter(sentence);
            MethodsForStrings.GetLastWordEE(sentence);
            MethodsForStrings.GetLastWordWithParams(sentence, 3, 5);
            MethodsForStrings.GetNumberOfUnickWords(sentence);

            var words = new List<string>()
            {
                "asdasdasd",
                "asa3fdasfasf",
                "3",
                "asdadsadsada",
                "qweqwesdsac4",
                "33",
                "asdasdsadvxvxcvs",
                "sdfasdfafdsf3"
            };

            MethodsForStrings.GetElementsWith3(words);
            MethodsForStrings.GetSmallestWord(words);

            var dictonary = new Dictionary<int, string>()
            {
                {1, "a" },
                {2, "b"},
                {3, "c"},
                {4, "d"},
                {5, "e"},
            };

            MethodsForStrings.ConvertDictonary(dictonary);
        }
    }
}

