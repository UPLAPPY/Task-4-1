using inf_to_2024._02._02;
using inf_to_2024._02._02.Classes;
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
            IPrinter[] printer = new IPrinter[4];
            IElGenerator<int> IntGenerator = new GeneratorInt();
            IElGenerator<string> StringGenerator = new GeneratorString();
            IElGenerator<double> DoubleGenerator = new GeneratorDouble();
            IElGenerator<bool> BoolGenerator = new GeneratorBool();

            printer[0] = new Array1<double>(false, DoubleGenerator);
            printer[1] = new Array1<string>(true, StringGenerator);
            printer[2] = new Array2<int>(false, IntGenerator);
            printer[3] = new Array2<bool>(true, BoolGenerator);

            for (int i = 0; i < printer.Length; i++)
            {
                printer[i].PrintArray();
            }
        }
    }
}