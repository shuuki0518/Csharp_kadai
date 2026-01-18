using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 3;

            Console.WriteLine("足し算：" + (x + y));
            Console.WriteLine("引き算：" + (x - y));
            Console.WriteLine("掛け算：" + (x * y));
            Console.WriteLine("割り算：" + (x / y)); // 整数の割り算

            Console.ReadLine();

        }
    }
}
