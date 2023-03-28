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

namespace ConsoleAppHello.HomeTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task2
            var polo = new Machine<GasMotor>(new GasMotor());
            polo.Move();
            polo.Refuel();

            //Task3
            var point1 = new Point<double>(12, 15);
            var point2 = new Point<double>(25, 30);
            point1.GetPoint();
            point2.GetPoint();
            Point<double>.Distance(point1, point2);
            
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
            dictonary.Add("жарко", "hot");
            dictonary.Add("морозно", "frosty");
            dictonary.Add("солнечно", "sunny");
            dictonary.Add("ясно", "clear");
            dictonary.Add("душно", "stuffy");
            dictonary.Add("облачно", "cloudy");
            dictonary.Add("ветренно", "windy");
            dictonary.Add("сухо", "dry");

            foreach (var item in dictonary)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

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
            findBread.Price -= 100;

            //Удалить последний продукт.

            products.RemoveAt(3);

            //Распечатать его содержимое

            var prodictkit = new ProductKit("My kit", 2500, products);
            prodictkit.GetInfo();

            //Удалить все продукты.

            products.Clear();

            //Создать коллекцию, содержащую объекты Product.
            //Написать метод, который перебирает элементы коллекции и проверяет цену продуктов.
            //Если цена продукта больше 300 рублей, продукт перемещается в другую коллекцию.
            //Необходимо вывести минимальное значение продукта из полученной коллекции.

            List<Product> products1 = new List<Product>();
            List<Product> products2 = new List<Product>()
            {
                new Product("Bread", 200, new DateTime(2023, 3, 20), new DateTime(2023, 4, 1)),
                new Product("Milk", 300, new DateTime(2023, 3, 10), new DateTime(2023, 3, 23)),
                new Product("Chocolate", 400, new DateTime(2023, 2, 10), new DateTime(2023, 6, 10)),
                new Product("Apple", 350, new DateTime(2022, 11, 15), new DateTime(2023, 5, 15)),
            };

            foreach (var item in products2)
            {
                if (item.Price > 300)
                {
                    products1.Add(item);
                    //products2.RemoveAt(products2.IndexOf(item)); выдаёт ошибку после удаления
                }
            }
            foreach (var item in products1) { item.GetInfo(); }

            products1.Sort(delegate (Product x, Product y)
            {
                return x.Price.CompareTo(y.Price);
            });

            Console.WriteLine($"Min price: {products1[0].Price}");

            //Создайте Dictionary, содержащий пары значений  - имя продукта и количестов единиц продукта (класс Product).
            //Перебрать и распечатать пары значений в формате "Name = abc, Count = 5"
            //Перебрать и распечатать набор из имен продуктов
            //Перебрать и распечатать значения количества единиц продуктов.
            //Для каждого перебора создать свой метод.

            var products3 = new Dictionary<Product, int>()
            {
                {new Product("Bread", 200, new DateTime(2023, 3, 20), new DateTime(2023, 4, 1)), 2},
                {new Product("Chocolate", 400, new DateTime(2023, 2, 10), new DateTime(2023, 6, 10)), 1},
                {new Product("Apple", 250, new DateTime(2022, 11, 15), new DateTime(2023, 5, 15)), 8}
            };

            new DictonaryHelper(products3).GetKeyValue();
            new DictonaryHelper(products3).GetKeyName();
            new DictonaryHelper(products3).GetValue();

            //На основе задания 3 необходимо написать преобразование:
            //Dictionary в List.

            List<KeyValuePair<Product, int>> products4 = products3.ToList();
        }
    }
}

