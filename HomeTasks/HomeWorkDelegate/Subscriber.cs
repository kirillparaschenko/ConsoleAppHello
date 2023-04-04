using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHello.HomeTasks.HomeWorkDelegate
{
    public class Subscriber
    {
        public Subscriber(string email, int targetPrice)
        {
            Email = email;
            TargetPrice = targetPrice;
        }

        public string Email { get; set; }
        public int TargetPrice { get; set; }

        public void SendEmail(int price)
        {
            if (TargetPrice > price)
            {
                Console.WriteLine($"Current price just {price}");
            }
        }

    }
}
