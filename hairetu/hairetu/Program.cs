using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hairetu
{
    class Program
    {
        static void Main(string[] args)
        {

            //配列 + Contains
            Console.WriteLine("配列のContains判定");

            string[] array = { "aaa", "bbb", "ccc", "ddd", "abc" };

            if (array.Contains("aaa"))
            {
                Console.WriteLine("含んでいます");
            }
            else
            {
                Console.WriteLine("含んでいません");
            }

            Console.WriteLine();

            //List操作
            Console.WriteLine("Listの操作");

            // List<string> bird を作成
            List<string> bird = new List<string>();

            // 要素を追加
            bird.Add("crow");
            bird.Add("sparrow");
            bird.Add("swallow");
            bird.Add("pigeon");

            // 「sparrow」を削除
            bird.Remove("sparrow");

            // インデックス1（1番目）を削除
            bird.RemoveAt(1);

            // foreachで全表示
            foreach (string b in bird)
            {
                Console.WriteLine(b);
            }
        }
    }
}
