using inf_to_2024._02._02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf_to_2024._02._02
{
    sealed class Array1<T> : BaseArr
    {
        private T[] Array;
        private IElGenerator<T> _elementGenerator;

        public Array1(bool avto_input, IElGenerator<T> ElementGenerator)
        {
            _elementGenerator = ElementGenerator;
            Create(avto_input);
        }

        public override void Create(bool avto_input)
        {
            Console.WriteLine("Введите количество элементов массива:");
            int _len = Convert.ToInt32(Console.ReadLine());
            Array = new T[_len];
            base.Create(avto_input);
        }

        public override void ArrayInput()
        {
            Console.WriteLine("Введите элементы, каждый с новой строки");
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = _elementGenerator.InputElements();
            }
        }

        public override void AvtoInput()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = _elementGenerator.GenerateRandom();
            }
        }

        public override void PrintArray()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write(Array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}