using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf_to_2024._02._02
{
    sealed class Array2: BaseArr
    {
        static int stroki, stolbiki;
        static int[,] arr;

        public Array2(bool AvtoInput)
        {
            Create(AvtoInput);
        }

        public override void Create(bool AvtoInput)
        {
            Console.WriteLine("Введите количество строк и столбцов массива, \n" +
                    "Каждое значение с новой строки:");
            stroki = Convert.ToInt32(Console.ReadLine());
            stolbiki = Convert.ToInt32(Console.ReadLine());
            arr = new int[stroki, stolbiki];
            if (AvtoInput)
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
            Random rnd = new Random();

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
            Console.WriteLine("Введите элементы, каждый с новой строки");
            for (int i = 0; i < stroki; i++)
            {
                for (int j = 0; j < stolbiki; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public override void PrintArray()
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

        public override void Average()
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