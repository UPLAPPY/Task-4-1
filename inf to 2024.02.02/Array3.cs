using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace inf_to_2024._02._02
{
    sealed class Array3: BaseArr, IBaseArr, IPrinter
    {
        private int[][] arr;

        private static Random rnd = new Random();

        public Array3(bool avto_input)
        {
            Create(avto_input);
        }

        public override void Create(bool avto_input)
        {
            Console.WriteLine("Введите количество подмассивов массива:");
            int stroki = Convert.ToInt32(Console.ReadLine());
            arr = new int[stroki][];
            if (avto_input)
            {
                AvtoInput();
            }
            else
            {
                ArrayInput();
            }
        }

        public override void AvtoInput()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Введите количество элементов данного подмассива:");
                int stolbiki = Convert.ToInt32(Console.ReadLine());
                arr[i] = new int[stolbiki];
                for (int j = 0; j < stolbiki; j++)
                {
                    arr[i][j] = rnd.Next(1, 33);
                }
            }
        }

        public override void ArrayInput()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Введите количество элементов данного подмассива");
                int stolbiki = Convert.ToInt32(Console.ReadLine());
                arr[i] = new int[stolbiki];
                Console.WriteLine($"Введите {stolbiki} элементов \n" +
                    "Каждый с новой строки:");
                for (int j = 0; j < stolbiki; j++)
                {
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public override void Average()
        {
            BigAverage();
            SmallAverage();
        }

        public void BigAverage()
        {
            int sum = 0, counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    sum += arr[i][j];
                    counter++;
                }
            }
            Console.WriteLine("Среднее значение всего массива:");
            Console.WriteLine(sum / counter);
        }

        public void SmallAverage()
        {
            Console.WriteLine("Средние значения каждого подмассива:");
            int sum = 0, counter = 0;
            for (int i = 0; i < arr[i].Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    sum += arr[i][j];
                    counter++;
                }
                Console.WriteLine(sum / counter);
                sum = 0;
                counter = 0;
            }
        }
        public override void PrintArray()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}