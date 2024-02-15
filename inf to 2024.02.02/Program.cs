using inf_to_2024._02._02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace inf_to_2024._02._02
{
    internal class Program
    {
        public static void Main()
        {
            IBaseArr[] testArrays = new IBaseArr[3];

            testArrays[0] = new Array1(false);
            Console.WriteLine();
            testArrays[1] = new Array2(false);
            Console.WriteLine();
            testArrays[2] = new Array3(false);
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                testArrays[i].PrintArray();
                Console.WriteLine($"Average: ");
                testArrays[i].Average();
                testArrays[i].Create(true);
                testArrays[i].PrintArray();
                Console.WriteLine();
            }
        }
    }
}