using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHello.HomeTasks.HomeWork9
{
    /// <summary>
    /// 1. Напишите обобщенный класс, который может хранить в массиве объекты любого типа.
    /// Кроме того, данный класс должен иметь методы для добавления данных в массив, удаления из массива, получения элемента из массива по индексу и метод, возвращающий длину массива.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MySuperClass<T>
    {
        public List<T> SuperList { get; set; }
        public void AddItem(T item)
        {
            SuperList.Add(item);
        }
        public void RemoveItem(T item)
        {
            SuperList.Remove(item);
        }
        public T GetItem(int index) 
        {
            return SuperList[index];
        }
        public int GetLength()
        {
            return SuperList.Count;
        }

    }
}
