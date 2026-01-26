using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hanpukushori
{
    class Program
    {
        static void Main(string[] args)
        {

            //for
            Console.WriteLine("1から10まで表示");
            for(int i = 1; i <= 10; i++)
            {

                Console.WriteLine(i);

            }

            Console.WriteLine();

            //foreach
            Console.WriteLine("配列表示");
            string[] fruits = { "apple", "orange", "grape" };

            foreach(string fruit in fruits)
            {

                Console.WriteLine(fruit);

            }

            Console.WriteLine();

            //while
            Console.WriteLine("合計が100を超えるまで入力");

            int sum = 0;

            while (sum <= 100)
            {
                Console.Write("数字を入力してください：");
                int number = int.Parse(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine($"合計は{sum}です");

        }
    }
}
