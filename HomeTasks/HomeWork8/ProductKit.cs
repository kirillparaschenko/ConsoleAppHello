using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHello.HomeTasks.HomeWork8
{
    /// <summary>
    /// Комплект (названия, цена, перечень продуктов)
    /// со своими методами вывода информации на экран, и определения соответствия сроку годности.
    /// </summary>
    public class ProductKit
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public List<Product> Products { get; set;}

        public ProductKit(string name, double price, List<Product> products) 
        {
            this.Name = name;
            this.Price = price;
            this.Products = products;
        }

        public void GetInfo() 
        {
            Console.WriteLine($"{Name} Price: {Price}\n");
            foreach(var item in Products) 
            {
                Console.Write(item.Name + " ");
            }
        }

        public void CheckExpirationDate() 
        {
            foreach(var item in Products)
            {
                item.CheckExpirationDate();
            }
        }
    }
}
