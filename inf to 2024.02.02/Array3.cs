using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_на_26._01._2024_финал
{
    class Array3
    {
        public static int stroki, stolbiki;
        public static int[][] arr;
        public static bool _avto_input = false;

        static Random rnd = new Random();

        public Array3(int Str, bool avto_input)
        {
            stroki = Str;
            _avto_input = avto_input;
            arr = new int[stroki][];
            if (_avto_input)
            {
                AvtoInput();
            }
            else
            {
                InputArray();
            }
        }

        public static void AvtoInput()
        {
            for (int i = 0; i < stroki; i++)
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

        public static void InputArray()
        {
            for (int i = 0; i < stroki; i++)
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

        public void Big_Average()
        {
            int sum = 0, counter = 0;
            for (int i = 0; i < stroki; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    sum += arr[i][j];
                    counter++;
                }
            }
            Console.WriteLine(sum / counter);
        }

        public void Small_Average()
        {
            int sum = 0, counter = 0;
            for (int i = 0; i < stroki; i++)
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

        public void ChangeChetToPr()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] % 2 == 0)
                    {
                        arr[i][j] = i * j;
                    }
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void ArrayOutput()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}