using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_capsule
{
    class Employee
    {

        //自動プロパティ(カプセル化)
        public string EmployeeId { get; set; }
        public string Name { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {

            //オブジェクト生成
            Employee emp = new Employee();

            //プロパティに値設定
            emp.EmployeeId = "E002";
            emp.Name = "田中花子";

            //出力
            Console.WriteLine(emp.EmployeeId);
            Console.WriteLine(emp.Name);

        }
    }
}
