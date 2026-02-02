using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_keisho
{
    class TestPerson
    {
        //変数宣言
        protected string name;
        protected int age;

        //コンストラクタ
        public TestPerson(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        //コンソール出力処理1
        public void PrintBaseMessage()
        {
            Console.WriteLine("基底クラス");
        }

        //コンソール出力処理2
        public void PrintBaseInfo()
        {
            Console.WriteLine("名前：" + name + ",年齢：" + age);
        }
    }

    class TestInfo : TestPerson
    {
        //変数宣言
        private int height;
        private int weight;

        //コンストラクタ
        public TestInfo(string name, int age, int height, int weight)
            : base(name, age)
        {
            this.height = height;
            this.weight = weight;
        }

        //コンソール出力処理3
        public void PrintDerivedMessage()
        {
            Console.WriteLine("派生クラス");
        }

        //コンソール出力処理4
        public void PrintDerivedInfo()
        {
            Console.WriteLine("身長：" + height + " ,体重：" + weight);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //派生クラスのインスタンス生成
            TestInfo info = new TestInfo("山田", 20, 170, 60);

            //基底クラスの出力
            info.PrintBaseMessage();
            info.PrintBaseInfo();

            //派生クラスの出力
            info.PrintDerivedMessage();
            info.PrintDerivedInfo();
        }
    }
}
