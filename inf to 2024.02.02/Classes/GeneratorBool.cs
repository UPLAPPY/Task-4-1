using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf_to_2024._02._02.Classes
{
    internal class GeneratorBool: IElGenerator<bool>
    {
        private static Random _random = new Random();
        public bool GenerateRandom()
        {
            bool answer = false;
            int flag = _random.Next(0, 2);
            if (flag == 1)
            {
                answer = true;
            }
            return answer;
        }

        public bool InputElements()
        {
            bool flag = Convert.ToBoolean(Console.ReadLine());
            return flag;
        }
    }
}
