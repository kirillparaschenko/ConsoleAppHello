using System;
using System.Transactions;
using System.Xml.Linq;

namespace ConsoleAppHello.HomeTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1

            Phone phone1 = new Phone(291111111, "Samsung", 111);
            Phone phone2 = new Phone(292222222, "Nokia", 112);
            Phone phone3 = new Phone(293333333, "Apple", 113);

            Console.WriteLine($"Number: {phone1.number}, Model: {phone1.model}, Weight: {phone1.weight}");
            Console.WriteLine($"Number: {phone2.number}, Model: {phone2.model}, Weight: {phone2.weight}");
            Console.WriteLine($"Number: {phone3.number}, Model: {phone3.model}, Weight: {phone3.weight}");

            phone1.GetNumber(phone1.number);
            phone2.GetNumber(phone2.number);
            phone3.GetNumber(phone3.number);

            phone1.ReceiveCall("Olya");
            phone2.ReceiveCall("Liza");
            phone3.ReceiveCall("Vasya");

            phone1.ReceiveCall("Andrei", phone1.number);

            int[] list = { phone1.number, phone2.number, phone3.number };
            Phone.SendMessages(list);
        }
    }
}

