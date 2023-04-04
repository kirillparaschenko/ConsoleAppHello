using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHello.HomeTasks.HomeWorkDelegate
{
    /// <summary>
    /// Cоздать класс мониторинга средней цен на жилье, цена будет генерироваться с помощью класса рандом и выдавать случайное значение в определенном диапазоне.
    /// Для того чтобы вывод цены был удобен пользователю в классе мониторинга создать поле делегат, обьект которого будет создаваться в классе мониторинга. 
    /// Пользователь указывает метод для отображения цены в удобном ему формате путем передачи метода в конструктор класса мониторинга.
    /// </summary>
    /// <param name="price"></param>
    
    public class PriceMonitor
    {
        public delegate void ShowPrice(int price);
        public delegate void CheckPrice(int price);
        public event CheckPrice? notify;
        private ShowPrice priceViewer;
        
        Random rnd = new Random();

        public int Price { get; set; }

        public PriceMonitor(ShowPrice add)
        {
            Price = (int)rnd.NextInt64(0, 100000);
            this.priceViewer = add;
        }

        public void DisplayPrice()
        {
            priceViewer(Price);
            notify(Price);
        }
    }
}
