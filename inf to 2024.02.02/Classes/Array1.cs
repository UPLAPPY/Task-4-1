using inf_to_2024._02._02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf_to_2024._02._02
{
    sealed class Array1<T>
    {
        private T[] array;
        private int _capacity;
        private int _size;

        public Array1(int capacity)
        {
            _capacity = capacity;
            array = new T[_capacity];
            _size = 0;
        }

        public Array1() : this(7)
        {
        }

        public void Add(T item)
        {
            if (_size >= _capacity)
            {
                _capacity = _capacity * 2 + 1;
                Array.Resize(ref array, _capacity);
            }
            array[_size] = item;
            _size++;
        }

        public T[] Method(Func<T, bool> condition)
        {
            T[] newArray = new T[array.Length];
            int count = 0;
            for (int i = 0; i < newArray.Length; i++)
            {
                if (condition(array[i]))
                {
                    newArray[count] = array[i];
                    count++;
                }
            }
            Array.Resize(ref newArray, count);
            return newArray;
        }

        public void Reverse()
        {
            Array.Reverse(array);
        }

        public void Remove(Func<T, bool> item)
        {
            T[] newArray = new T[_size - 1];
            for (int i = 0; i < _size; i++)
            {
                if (!item(array[i]))
                {
                    newArray[i] = array[i];
                }
            }
            _size--;
            Array.Copy(newArray, 0, array, 0, _size);
        }

        public void ForEachAction(Action<T> action)
        {
            for (int i = 0; i < array.Length; i++)
            {
                action(array[i]);
            }
        }
    }
}