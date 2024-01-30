using inf_to_2024._02._02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf_to_2024._02._02
{
    sealed class Array1: BaseArr
    {
        static private int _len;
        static private bool _avto_input;
        public int[] Array;

        static Random rnd = new Random();

        public Array1(bool avto_input)
        {
            Create(avto_input);
        }

        public override void Create(bool avto_input)
        {
            Console.WriteLine("Введите количество элементов массива:");
            _len = Convert.ToInt32(Console.ReadLine());
            Array = new int[_len];
            _avto_input = avto_input;
            if (_avto_input)
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

        public override void PrintArray()
        {
            foreach (int el in Array)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
        }

        public override void Average()
        {
            int sum = 0;
            foreach (int num in Array)
            {
                sum += num;
            }
            Console.WriteLine(sum / _len);
        }


        public void DeleteMore100()
        {
            int NewArrLength = 0;
            for (int i = 0; i < _len; i++)
            {
                if (Array[i] >= -100 && Array[i] <= 100)
                {
                    NewArrLength += 1;
                }
            }
            int[] answ = new int[NewArrLength];
            int index = 0;
            foreach (int num in Array)
            {
                if (num >= -100 && num <= 100)
                {
                    answ[index] = num;
                    index += 1;
                }
            }
            for (int i = 0; i < NewArrLength; i++)
            {
                Console.Write(answ[i] + " ");
            }
            Console.WriteLine();
        }

        public void DeletePovtor()
        {
            DeletePovt.GetArrayWithoutDuplicates(Array);
        }
    }

    class DeletePovt
    {
        public static void GetArrayWithoutDuplicates(int[] array)
        {
            int newArrayLength = array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] == array[j] && i != j)
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

            for (int i = 0; i < array.Length; i++)
            {
                if (!Exists(array[i], newArray))
                {
                    newArray[counter] = array[i];
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
    }
}