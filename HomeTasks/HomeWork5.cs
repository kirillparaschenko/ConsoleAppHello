using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHello.HomeTasks
{
    /// <summary>
    /// 1. Класс Phone.  
    /// Создайте класс Phone, который содержит переменные number, model и weight. Создайте три экземпляра этого класса.  
    /// Выведите на консоль значения их переменных.  
    /// Добавить в класс Phone методы: receiveCall, имеет один параметр – имя звонящего. Выводит на консоль сообщение “Звонит { name}”. 
    /// getNumber –  возвращает номер телефона.Вызвать эти методы для каждого из  объектов.
    /// Добавить конструктор в класс Phone, который принимает на вход три параметра для инициализации переменных класса - number, model и  weight.
    /// Добавить конструктор, который принимает на вход два параметра для  инициализации переменных класса - number, model.
    /// Добавить конструктор без параметров.
    /// Вызвать из конструктора с тремя параметрами конструктор с двумя.  
    /// Добавьте перегруженный метод receiveCall, который принимает два параметра - имя звонящего и номер телефона звонящего. Вызвать этот  метод.
    /// Создать метод sendMessage с аргументами переменной длины.Данный метод принимает на вход номера телефонов, которым будет отправлено сообщение. 
    /// Метод выводит на консоль номера этих телефонов.
    /// </summary>
    internal class Phone
    {
        public int number;
        public string model;
        public double weight;

        public void ReceiveCall(string name)
        {
            Console.WriteLine($"Звонит {name}");
        }

        public void ReceiveCall(string name, int number)
        {
            Console.WriteLine($"Звонит {name} {number}");
        }

        public int GetNumber(int number)
        {
            return number;
            Console.WriteLine($"Number: {number}");
        }

        public static void SendMessages(params int[] list)
        {
            foreach (int i in list)
            {
                Console.WriteLine($"Number: {i}");
            }
        }

        public Phone(int number, string model, double weight)
        {
            this.number = number;
            this.model = model;
            this.weight = weight;
        }

        public Phone(int number, string model) : this(number, model, 0)
        {
            this.number = number;
            this.model = model;
        }

        public Phone()
        {
        }
    }
}
