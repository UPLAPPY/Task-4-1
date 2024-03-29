using inf_to_2024._02._02;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace inf_to_2024._02._02
{ 

    class Array1<T>
    {

        private T[] array;
        private int _capacity;
        private int _size;

        public Array1(int capacity)
        {
            _capacity = capacity;
            array = new T[capacity];
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

        public void Reverse()
        {
            T[] newArray = new T[_size];
            for (int i = _size - 1; i >= 0; i--)
            {
                newArray[i] = array[_size - i - 1];
            }
            Array.Copy(newArray, 0, array, 0, _size);
        }


        public int Amount()
        {
            return _size;
        }

        public int CountAmount(Func<T, bool> cond)
        {
            T[] newArray = Method(cond);
            return newArray.Length;
        }

        public void Remove(T item, Func<T, T, bool> deleg)
        {
            T[] newArray = new T[_size];
            int mark = 0;
            for (int i = 0; i < _size; i++)
            {
                if (!deleg(item, array[i]))
                {
                    newArray[i] = array[i];
                }
                else
                {
                    mark = i;
                }
            }
            Array.Copy(newArray, 0, array, 0, _size - 1);
            for (int i = mark; i < _size; i++)
            {
                array[i] = array[i + 1];
            }
            _size--;

        }

        public T[] Method(Func<T, bool> condition)
        {
            T[] newArray = new T[_size];
            int count = 0;
            for (int i = 0; i < _size; i++)
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

        public void ActionForAll(Func<T, T> condition)
        {
            T[] newArray = new T[_size];
            for (int i = 0; i < _size; i++)
            {
                array[i] = condition(array[i]);
            }

            for (int i = 0; i < _size; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("");
        }

        public bool IfForOne(Func<T, bool> cond)
        {
            T[] newArray = Method(cond);
            if (newArray.Length > 0)
            {
                return true;
            }
            return false;
        }

        public bool IfForAll(Func<T, bool> cond)
        {
            T[]newArray = Method(cond);
            if (newArray.Length == _size)
            {
                return true;
            }
            return false;
        }

        public void PrintArray()
        {
            for (int i = 0; i < _size; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("");
        }
    }
}