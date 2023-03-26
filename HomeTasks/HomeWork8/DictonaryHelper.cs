using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHello.HomeTasks.HomeWork8
{
    public class DictonaryHelper
    {
        public Dictionary<Product, int> Products { get; set; }
        public DictonaryHelper(Dictionary<Product, int> products) 
        {
            this.Products = products;
        }
        public void GetKeyValue()
        {
            foreach (var item in Products)
            {
                Console.WriteLine($"Name = {item.Key.Name}, Count = {item.Value}");
            }
        }
        public void GetKeyName()
        {
            foreach (var item in Products)
            {
                Console.WriteLine(item.Key.Name);
            }
        }
        public void GetValue() 
        {
            foreach (var item in Products)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
