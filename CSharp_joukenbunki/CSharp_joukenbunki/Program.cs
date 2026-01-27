using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_joukenbunki
{
    class Program
    {
        static void Main(string[] args)
        {

            //奇数・偶数判定
            Console.WriteLine("偶数・奇数判定");
            Console.WriteLine("整数を入力してください");
            int number = int.Parse(Console.ReadLine());

            if(number%2==0)
            {
                Console.WriteLine("偶数");
            }
            else
            {
                Console.WriteLine("奇数");
            }

            Console.WriteLine();

            //曜日判定（switch文）
            Console.WriteLine("曜日判定");
            Console.Write("1～7の数字を入力してください: ");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("月曜日");
                    break;
                case 2:
                    Console.WriteLine("火曜日");
                    break;
                case 3:
                    Console.WriteLine("水曜日");
                    break;
                case 4:
                    Console.WriteLine("木曜日");
                    break;
                case 5:
                    Console.WriteLine("金曜日");
                    break;
                case 6:
                    Console.WriteLine("土曜日");
                    break;
                case 7:
                    Console.WriteLine("日曜日");
                    break;
                default:
                    Console.WriteLine("不正な入力です");
                    break;
            }

            Console.WriteLine();

            //学生割引判定
            Console.WriteLine("学生割引判定");
            Console.WriteLine("// int age = 20;          // 年齢");
            Console.WriteLine("//bool isStudent = true; // 学生かどうか");

            int age = 20;          // 年齢
            bool isStudent = true; // 学生かどうか

            if (age >= 18 && isStudent)
            {
                Console.WriteLine("学生割引が適用されます");
            }

            //④ログイン判定
            Console.WriteLine("ログイン判定");

            Console.Write("ログインIDを入力してください: ");
            string loginId = Console.ReadLine();

            Console.Write("パスワードを入力してください: ");
            string password = Console.ReadLine();

            // OR条件（どちらか一致すれば成功）
            if (loginId == "admin" || password == "password123")
            {
                Console.WriteLine("ログイン成功");
            }
            else
            {
                Console.WriteLine("ログイン失敗");
            }

            Console.WriteLine();

            //⑤点数による評価
            Console.WriteLine("点数評価");

            Console.Write("点数を入力してください: ");
            int score = int.Parse(Console.ReadLine());

            if (score >= 80 && score <= 100)
            {
                Console.WriteLine("優秀");
            }
            else if (score >= 60 && score < 80)
            {
                Console.WriteLine("合格");
            }
            else
            {
                Console.WriteLine("不合格");
            }

            //ctrl + F5

        }
    }
}
