using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_class_object
{
    class Program
    {
        static void Main(string[] args)
        {

            //HelloWorld表示
            ShowhelloWorld();

            Console.WriteLine();

            //文字列結合
            ConcatStrings();

        }

        //HelloWorld表示メソッド
        static void ShowhelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        //文字列入力後、結合するメソッド
        static void ConcatStrings()
        {
            Console.Write("コンソールに文字列１を入力：");
            string str1 = Console.ReadLine();

            Console.Write("コンソールに文字列２を入力：");
            string str2 = Console.ReadLine();

            string result = str1 + str2;
            Console.WriteLine($"出力：{result}");
        }
    }
}
