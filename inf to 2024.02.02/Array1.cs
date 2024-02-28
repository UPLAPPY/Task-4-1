using inf_to_2024._02._02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf_to_2024._02._02
{
    sealed class Array1 : BaseArr, IArray1
    {
        private int[] Array;

        private static Random rnd = new Random();

        public Array1(bool avto_input)
        {
            Create(avto_input);
        }

        public override void Create(bool avto_input)
        {
            Console.WriteLine("Введите количество элементов массива:");
            int _len = Convert.ToInt32(Console.ReadLine());
            Array = new int[_len];
            base.Create(avto_input);
        }

        public override void ArrayInput()
        {
            Console.WriteLine("Введите элементы, каждый с новой строки");
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public override void AvtoInput()
        {
            for (int i = 0; i < Array.Length; i++)
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
            Console.WriteLine(sum / Array.Length);
        }
    }
}