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
        static bool IntFunc1(int x)
        {
            return x == 3;
        }
        static bool IntFunc2(int x)
        {
            return x % 3 == 0;
        }
        //static bool IntFunc3(int x)

        public static void Main()
        {
            Array1<int> IntArr = new Array1<int>();
            for (int i = 0; i < 8; i++)
            {
                IntArr.Add(i);
            }
            IntArr.PrintArray();
            int y = 3;
            IntArr.Reverse();
            IntArr.PrintArray();
            Console.WriteLine(IntArr.Amount());
            Console.WriteLine(IntArr.CountAmount((x) => IntFunc1(x)));
            IntArr.Remove(y, (a, b) => a == b);
            IntArr.PrintArray();
            Console.WriteLine(IntArr.IfForOne((x) => x % 3 == 0));
            Console.WriteLine(IntArr.IfForAll((x) => x % 2 == 0));
            IntArr.ActionForAll((x) => x * x);
            IntArr.PrintArray();
            Console.WriteLine($"{IntArr.Min()} {IntArr.Max()}");

            Array1<string> StringArr = new Array1<string>();
            for (int i = 0; i < 8; i++)
            {
                StringArr.Add($"{i + 1}");
            }
            StringArr.PrintArray();
            string g = "3";
            StringArr.Reverse();
            StringArr.PrintArray();
            Console.WriteLine(StringArr.Amount());
            Console.WriteLine(StringArr.CountAmount((x) => x == "IHBPFJASTMNEYNEDMMKYAMAITTRTD"));
            StringArr.Remove(g, (a, b) => a == b);
            StringArr.PrintArray();
            Console.WriteLine(StringArr.IfForOne((x) => x != "TUTUTUTU33"));
            Console.WriteLine(StringArr.IfForAll((x) => x != "Smooth Operatooor"));
            StringArr.ActionForAll((x) => x + "ab");
            StringArr.PrintArray();
            Console.WriteLine($"{StringArr.Min()} {StringArr.Max()}");
        }
    }
}