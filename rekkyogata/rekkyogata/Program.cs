using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rekkyogata
{
    class Program
    {

        //列挙型enum
        enum DayOfWeekEnum
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        static void Main(string[] args)
        {

            //enumをforeachで出力
            foreach(DayOfWeekEnum day in Enum.GetValues(typeof(DayOfWeekEnum)))
            {
                Console.WriteLine(day);
            }

        }
    }
}
