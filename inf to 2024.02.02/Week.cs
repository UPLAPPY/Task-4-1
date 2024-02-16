using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf_to_2024._02._02
{
    interface IWeek : IPrinter
    {
        void PrintArray();
    }
    sealed class Week: IWeek
    {
        DateTime dateTime;
        public Week() 
        {
            dateTime = DateTime.Now;
        }

        public void PrintArray()
        {
            Console.WriteLine("Day of week: ");
            Console.WriteLine(dateTime.DayOfWeek);
        }
    }
}
