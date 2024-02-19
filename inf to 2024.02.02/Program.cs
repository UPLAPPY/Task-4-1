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
            testArrays[1] = new Array2(false);
            testArrays[2] = new Array3(false);

            for (int i = 0; i< 3; i++)
            {
                testArrays[i].PrintArray();
                testArrays[i].Average();
                testArrays[i].Create(true);
                if (i == 0)
                {
                    ((IArray1)testArrays[0]).DeleteRep();
                }
            }

            IPrinter[] printerArrays = new IPrinter[4];
            printerArrays[0] = testArrays[0];
            printerArrays[1] = testArrays[1];
            printerArrays[2] = testArrays[2];
            printerArrays[3] = new Week();

            for (int i = 0; i < 4; i++)
            {
                printerArrays[i].PrintArray();
            }
        }
    }
}