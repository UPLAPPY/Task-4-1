using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf_to_2024._02._02
{
    class Array2
    {
        static int stroki, stolbiki;
        static int[,] arr;
        static bool _AvtoInput = false;

        static Random rnd = new Random();

        public Array2(int Str, int Stl, bool AvtoInput)
        {
            stroki = Str;
            stolbiki = Stl;
            arr = new int[stroki, stolbiki];
            _AvtoInput = AvtoInput;
            if (_AvtoInput)
            {
                Avto_Input();
            }
            else
            {
                ArrayInput();
            }
        }

        private static void Avto_Input()
        {
            for (int i = 0; i < stroki; i++)
            {
                for (int j = 0; j < stolbiki; j++)
                {
                    arr[i, j] = rnd.Next(1, 33);
                }
            }
        }

        public static void ArrayInput()
        {
            Console.WriteLine("Введите матрицу");
            for (int i = 0; i < stroki; i++)
            {
                for (int j = 0; j < stolbiki; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void ArrayOutput()
        {
            for (int i = 0; i < stroki; i++)
            {
                for (int j = 0; j < stolbiki; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void ChangedArrayOutput()
        {
            for (int i = 0; i < stroki; i++)
            {
                for (int j = 0; j < stolbiki; j++)
                {
                    int index = (i % 2 != 0)
                        ? arr[i, stolbiki - j - 1]
                        : arr[i, j];
                    Console.Write(index + " ");
                }
                Console.WriteLine();
            }
        }

        public void Average()
        {
            int sum = 0;
            for (int i = 0; i < stroki; i++)
            {
                for (int j = 0; j < stolbiki; j++)
                {
                    sum += arr[i, j];
                }
            }
            Console.WriteLine(sum / (stroki * stolbiki));
        }
    }
}