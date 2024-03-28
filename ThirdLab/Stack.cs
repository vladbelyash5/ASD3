using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLab
{
    public class MyStack<T>
    {
        private T[] items; // элементы стека
        private int count; // количество элементов
        const int n = 10; // количество элементов в массиве по умолчанию
        public MyStack()
        {
            items = new T[n];
        }
        public MyStack(int length)
        {
            items = new T[length];
        }

        // пуст ли стек
        public bool IsEmpty
        {
            get { return count == 0; }
        }
        //размер стека
        public int Count
        {
            get { return count; }
        }
        //добавление элемента
        public void Push(T item)
        {
            //увеличиваем стек
            if (count == items.Length)
                Resize(items.Length + 10);

            items[count++] = item; 
        }

        //извлечение элемента
        public T Pop()
        {
            //если стек пуст, выбрасываем исключение
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");
            T item = items[--count];
            items[count] = default(T); // сбрасываем ссылку

            if (count > 0 && count < items.Length - 10)
                Resize(items.Length - 10);

            return item;
        }
        // возвращаем элемент из верхушки стека
        public T Peek()
        {
            // если стек пуст, выбрасываем исключение
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");
            return items[count - 1];
        }

        private void Resize(int max)
        {
            T[] tempItems = new T[max];
            for (int i = 0;i < count; i++)
                tempItems[i] = items[i];
            items = tempItems;
        }
    }
}
