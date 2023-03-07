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

            //Task 2
            // Тестовый сценарий для проверки:
            // Положите деньги на первые две карточки и снимите с третьей.
            // Выведите на экран текущее состояние всех трех карточек.

            CreditCard creditCard1 = new CreditCard("1111111111111111", 1000);
            CreditCard creditCard2 = new CreditCard("2222222222222222", 2000);
            CreditCard creditCard3 = new CreditCard("3333333333333333", 3000);

            creditCard1.AddSum(500);
            creditCard2.AddSum(500);
            creditCard3.SubtractSum(5000);

            creditCard1.GetInfo();
            creditCard2.GetInfo();
            creditCard3.GetInfo();

            int[] list = { phone1.number, phone2.number, phone3.number };
            Phone.SendMessages(list);

            //Task 2
            // Тестовый сценарий для проверки:
            // Положите деньги на первые две карточки и снимите с третьей.
            // Выведите на экран текущее состояние всех трех карточек.

            CreditCard creditCard1 = new CreditCard("1111111111111111", 1000);
            CreditCard creditCard2 = new CreditCard("2222222222222222", 2000);
            CreditCard creditCard3 = new CreditCard("3333333333333333", 3000);

            creditCard1.AddSum(500);
            creditCard2.AddSum(500);
            creditCard3.SubtractSum(500);

            creditCard1.GetInfo();
            creditCard2.GetInfo();
            creditCard3.GetInfo();
        }
    }
}

