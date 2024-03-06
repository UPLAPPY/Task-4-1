using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf_to_2024._02._02
{
    interface IElGenerator<T>
    {
        T GenerateRandom();
        T InputElements();
    }
}
