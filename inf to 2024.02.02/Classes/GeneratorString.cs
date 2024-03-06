using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf_to_2024._02._02.Classes
{
    class GeneratorString: IElGenerator<string>
    {
        private const string letters = "abcdefghijklmnopqrstuvwxyz";
        private static Random _random = new Random();
        public string GenerateRandom()
        {
            int length = _random.Next(0, 10);
            string answer = "";
            for (int i = 0; i < length; i++)
            {
                answer += letters[_random.Next(0, 26)];
            }
            return answer;
        }

        public string InputElements()
        {
            string word = Convert.ToString(Console.ReadLine());
            return word;
        }
    }
}
