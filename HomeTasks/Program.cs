using ConsoleAppHello.HomeTasks.HomeWork8;
using System;
using System.Collections;
using System.Transactions;
using System.Xml.Linq;

namespace ConsoleAppHello.HomeTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1. Необходимо перехватить ошибку и вывести на экран с указанием типа этой ошибки. 
            //ArrayList list = new ArrayList();
            //try
            //{
            //    object s = list[18];
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            ////2. Необходимо создать коллекцию Dictionary, в которой будет находиться 10 различных пар объектов.
            ////Необходимо вывести содержимое коллекции на экран.

            //var dictonary = new Dictionary<string, string>();

            //dictonary.Add("холодно", "cold");
            //dictonary.Add("тепло", "warm");
            //dictonary.Add("жарко" , "hot");
            //dictonary.Add("морозно" , "frosty");
            //dictonary.Add("солнечно" , "sunny");
            //dictonary.Add("ясно" , "clear");
            //dictonary.Add("душно" , "stuffy");
            //dictonary.Add("облачно" , "cloudy");
            //dictonary.Add("ветренно" , "windy");
            //dictonary.Add("сухо" , "dry");

            //foreach (var item in dictonary) 
            //{
            //    Console.WriteLine($"{item.Key} : {item.Value}");
            //}

            //3.1 Создать базу (List) из n товаров, вывести полную информацию из базы на экран,
            //а также организовать поиск просроченного товара (на момент текущей даты).
            List<Product> products = new List<Product>()
            {
                new Product("Bread", 200, new DateTime(2023, 3, 20), new DateTime(2023, 4, 1)),
                new Product("Milk", 300, new DateTime(2023, 3, 10), new DateTime(2023, 3, 23)),
                new Product("Chocolate", 400, new DateTime(2023, 2, 10), new DateTime(2023, 6, 10)),
                new Product("Apple", 250, new DateTime(2022, 11, 15), new DateTime(2023, 5, 15)),
            };
            foreach (var item in products)
            {
                item.GetInfo();
                item.CheckExpirationDate();
            }

            //Изменить цену одного продукта на 100. 

            var findBread = products.Find(x => x.Name == "Bread");
            products.Remove(findBread);
        }
    }
}

