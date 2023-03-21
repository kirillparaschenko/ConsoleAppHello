﻿using System;
using System.Collections;
using System.Transactions;
using System.Xml.Linq;

namespace ConsoleAppHello.HomeTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Необходимо перехватить ошибку и вывести на экран с указанием типа этой ошибки. 
            ArrayList list = new ArrayList();
            try
            {
                object s = list[18];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //2. Необходимо создать коллекцию Dictionary, в которой будет находиться 10 различных пар объектов.
            //Необходимо вывести содержимое коллекции на экран.

            var dictonary = new Dictionary<string, string>();

            dictonary.Add("холодно", "cold");
            dictonary.Add("тепло", "warm");
            dictonary.Add("жарко" , "hot");
            dictonary.Add("морозно" , "frosty");
            dictonary.Add("солнечно" , "sunny");
            dictonary.Add("ясно" , "clear");
            dictonary.Add("душно" , "stuffy");
            dictonary.Add("облачно" , "cloudy");
            dictonary.Add("ветренно" , "windy");
            dictonary.Add("сухо" , "dry");

            foreach (var item in dictonary) 
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}

