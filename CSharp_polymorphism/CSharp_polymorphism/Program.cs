using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_polymorphism
{
    using System;
    using System.Collections.Generic;

    //抽象クラス
    abstract class Employee
    {
        protected string id;
        protected string name;

        //コンストラクタ
        public Employee(string id, string name)
        {
            this.id = id;
            this.name = name;
        }

        //抽象メソッド
        public abstract int CalculateDailyWage(double hoursWorked);

        //共通出力用メソッド
        public void PrintWage(double hoursWorked)
        {
            int wage = CalculateDailyWage(hoursWorked);
            Console.WriteLine(
                "社員ID: " + id +
                ", 名前: " + name +
                ", 給料: " + wage
            );
        }
    }

    //正社員
    class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string id, string name)
            : base(id, name)
        {
        }

        //給料計算ロジック
        public override int CalculateDailyWage(double hoursWorked)
        {
            double hourly = 1250;
            double wage;

            if (hoursWorked > 8)
            {
                wage = (8 * hourly)
                     + ((hoursWorked - 8) * hourly * 1.25);
            }
            else
            {
                wage = hoursWorked * hourly;
            }

            return (int)wage;
        }
    }

    //契約社員
    class ContractEmployee : Employee
    {
        public ContractEmployee(string id, string name)
            : base(id, name)
        {
        }

        //給料計算ロジック
        public override int CalculateDailyWage(double hoursWorked)
        {
            return (int)(hoursWorked * 1000);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //List<Employee> に追加
            List<Employee> employees = new List<Employee>();

            employees.Add(new FullTimeEmployee("E001", "山田太郎"));
            employees.Add(new ContractEmployee("C001", "佐藤花子"));
            employees.Add(new FullTimeEmployee("E002", "鈴木一郎"));

            //foreach で共通処理
            employees[0].PrintWage(8.5);
            employees[1].PrintWage(8);
            employees[2].PrintWage(8);
        }
    }

}
