using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_hennsuu_kata
{
    class Program
    {
        static void Main(string[] args)
        {

            //①演算
            int num1 = 7;
            int num2 = 3;

            Console.WriteLine("① 演算");
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}余り{num1 % num2}");

            Console.WriteLine();

            //②型変換
            int intTest = 1;
            string stringTest = "01";

            Console.WriteLine("②型変換");

            //int -> stringに変換して文字列を追加
            string intToString = "string" + intTest.ToString();
            Console.WriteLine(intToString);

            // string → int に変換してインクリメント
            int stringToInt = int.Parse(stringTest);
            stringToInt++;
            Console.WriteLine(stringToInt);

            Console.WriteLine();

            // ③ double型の価格
            double price = 123.45;
            Console.WriteLine("③ 価格表示");
            Console.WriteLine($"価格: {price}");

            Console.WriteLine();

            // ④ 今日の日付
            DateTime today = DateTime.Today;
            Console.WriteLine("④ 今日の日付");
            Console.WriteLine($"今日の日付: {today:yyyy年M月d日}");

            //ctrl + F5でデバッグ実行

        }
    }
}
