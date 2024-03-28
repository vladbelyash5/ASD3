using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLab
{ 
    public class Queue<T> : IEnumerable
    {
        private int _head = -1;
        private int _tail = -1;
        private int _count = 0;
        private readonly int _size;
        private readonly T[] _array;

        public Queue(int size)
        {
            this._size = size;
            this._array = new T[size];
        }

        public bool IsFull()
        {
            return _tail == _size - 1;
        }

        public bool IsEmpty()
        {
            return _count == 0;
        }
        
        public void Enqueue(T item)//метод добавления элементов в очередь
        {
            if (this.IsFull())
                throw new Exception("Очередь полностью заполнена");

            _array[++_tail] = item;
            _count++;
        }

        public T Dequeue()//считывает, возвращает и удаляет элнт из очереди
        {
            if (this.IsEmpty())
                throw new Exception("Очередь не заполнена");

            T value = _array[++_head];
            _count--;
            if(_head == _tail)
            {
                _head = -1;
                _tail = -1;
            }
            return value;
        }

        public int Size
        { get { return _size; } }

        public int Count
        { get { return _count; } }

        public T Peek()
        {
            if (this.IsEmpty())
                throw new Exception("Очередь не заполнена");

            T value = _array[_head + 1];
            return value;
        }

        public IEnumerator GetEnumerator()
        {
            if (this.IsEmpty())
                throw new Exception("Очердь не заполнена");

            for (int i = _head + 1; i <= _tail; i++)
            {
                yield return _array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
