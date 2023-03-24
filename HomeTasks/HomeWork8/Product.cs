using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHello.HomeTasks.HomeWork8
{
    /// <summary>
    /// Продукт (название, цена, дата производства, срок годности),
    /// с методами, позволяющим вывести на экран информацию о товаре, 
    /// а также определить, соответствует ли она сроку годности на текущую дату.
    /// </summary>
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public DateTime ExpirationDate { get; set; }
        public Product(string name, double price, DateTime date, DateTime expirationDate) 
        {
            this.Name = name;
            this.Price = price;
            this.Date = date;
            this.ExpirationDate = expirationDate;
        }
        public virtual void GetInfo() 
        {
            Console.WriteLine($"{Name} Price: {Price}, Date: {Date.ToString("d")}, Expiration Date {ExpirationDate.ToString("d")} ");
        }
        public void CheckExpirationDate()
        {
            if (ExpirationDate < DateTime.Now)
            {
                Console.WriteLine("Expiration date has expired");
            }
            else
            {
                Console.WriteLine("Expiration date has not expired");
            }
        }
    }
}
