using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_abstract_class_interface
{
    using System;
    using System.Collections.Generic;

    //インターフェイス
    interface IBillable
    {
        int CostForDay(int hoursWorked);
    }

    //抽象クラス
    abstract class Employee : IBillable
    {
        public string Id { get; private set; }
        public string Name { get; private set; }

        //コンストラクタ
        public Employee(string id, string name)
        {
            Id = id;
            Name = name;
        }

        //抽象メソッド
        public abstract int CostForDay(int hoursWorked);
    }

    //正社員
    class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string id, string name)
            : base(id, name)
        {
        }

        public override int CostForDay(int hoursWorked)
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

        public override int CostForDay(int hoursWorked)
        {
            return hoursWorked * 1000;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //IBillable型で管理
            List<IBillable> employees = new List<IBillable>();

            employees.Add(new FullTimeEmployee("E001", "山田"));
            employees.Add(new ContractEmployee("C001", "佐藤"));

            //全員9時間勤務
            int hoursWorked = 9;

            foreach (IBillable emp in employees)
            {
                Console.WriteLine("日給: " + emp.CostForDay(hoursWorked) + "円");
            }
        }
    }

}
