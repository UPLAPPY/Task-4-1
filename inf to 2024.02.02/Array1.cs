using inf_to_2024._02._02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf_to_2024._02._02
{
    interface IArray1: IBaseArr
    {
        void DeleteRep();
    }

    sealed class Array1 : IArray1
    {
        private int _len;
        private int[] Array;

        private static Random rnd = new Random();

        public Array1(bool avto_input)
        {
            Create(avto_input);
        }

        public void Create(bool avto_input)
        {
            Console.WriteLine("Введите количество элементов массива:");
            _len = Convert.ToInt32(Console.ReadLine());
            Array = new int[_len];
            if (avto_input)
            {
                AvtoInput();
            }
            else
            {
                ArrayInput();
            }
        }

        private void ArrayInput()
        {
            Console.WriteLine("Введите элементы, каждый с новой строки");
            for (int i = 0; i < _len; i++)
            {
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        private void AvtoInput()
        {
            for (int i = 0; i < _len; i++)
            {
                Array[i] = rnd.Next(1, 33);
            }
        }

        public void PrintArray()
        {
            foreach (int el in Array)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        public void DeleteRep()
        {
            int newArrayLength = Array.Length;
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = i; j < Array.Length; j++)
                {
                    if (Array[i] == Array[j] && i != j)
                    {
                        newArrayLength--;
                        break;
                    }
                }
            }

            int[] newArray = new int[newArrayLength];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = int.MinValue;
            }
            int counter = 0;

            for (int i = 0; i < Array.Length; i++)
            {
                if (!Exists(Array[i], newArray))
                {
                    newArray[counter] = Array[i];
                    counter++;
                }
            }

            foreach (var item in newArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }



        private static bool Exists(int value, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return true;
                }
            }
            return false;
        }
        public void Average()
        {
            int sum = 0;
            foreach (int num in Array)
            {
                sum += num;
            }
            Console.WriteLine(sum / _len);
        }
    }
}