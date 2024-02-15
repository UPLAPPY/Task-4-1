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

            testArrays[0].PrintArray();
            Console.WriteLine($"Average: ");
            testArrays[0].Average();
            testArrays[0].Create(true);
            testArrays[0].PrintArray();
            testArrays[0].DeleteRep();

            testArrays[1].PrintArray();
            Console.WriteLine($"Average: ");
            testArrays[1].Average();
            testArrays[1].Create(true);
            testArrays[1].PrintArray();
            
            testArrays[2].PrintArray();
            Console.WriteLine($"Average: ");
            testArrays[2].Average();
            testArrays[2].Create(true);
            testArrays[2].PrintArray();

            Week day = new Week();
            day.PrintArray();
        }
    }
}