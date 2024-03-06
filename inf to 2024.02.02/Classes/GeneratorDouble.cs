using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf_to_2024._02._02.Classes
{
    internal class GeneratorDouble : IElGenerator<double>
    {
        private static Random _random = new Random();
        public double GenerateRandom()
        {
            double answer = _random.NextDouble();
            return answer;
        }

        public double InputElements()
        {
            double doub = Convert.ToDouble(Console.ReadLine());
            return doub;
        }
    }
}
