using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf_to_2024._02._02.Classes
{
    class GeneratorInt: IElGenerator<int>
    {
        private static Random _random = new Random(); 
        public int GenerateRandom()
        {
            return _random.Next(0, 100);
        }

        public int InputElements()
        {
            int el = Convert.ToInt32(Console.ReadLine());
            return el;
        }
    }
}
