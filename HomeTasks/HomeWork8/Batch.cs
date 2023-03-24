using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHello.HomeTasks.HomeWork8
{
    /// <summary>
    /// Партия (название, цена, количество шт, дата производства, срок годности)
    /// со своими методами вывода информации на экран, и определения соответствия сроку годности.
    /// </summary>
    public class Batch : Product
    {
        public Batch(string name, double price, DateTime date, DateTime expirationDate) : base(name, price, date, expirationDate)
        {
            this.Qty = Qty;
        }
        public int Qty { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"{Name} Qty: {Qty}, Price: {Price}, Date: {Date.ToString("d")}, Expiration Date {ExpirationDate.ToString("d")} ");
        }
    }
}
