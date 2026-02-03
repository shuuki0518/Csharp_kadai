using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_SOLID
{
    //データを持つクラス
    class Report
    {
        public string EmployeeName { get; private set; }
        public int HoursWorked { get; private set; }

        public Report(string employeeName, int hoursWorked)
        {
            EmployeeName = employeeName;
            HoursWorked = hoursWorked;
        }
    }

    //給与計算を行うクラス
    class ReportCalculator
    {
        public int CalculateWage(Report r)
        {
            int hourlyWage = 1000;
            return r.HoursWorked * hourlyWage;
        }
    }

    //レポートを保存するクラス
    class ReportSaver
    {
        public void Save(Report r)
        {
            Console.WriteLine("レポートを保存しました");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //レポート作成
            Report report = new Report("山田太郎", 8);

            //給与計算
            ReportCalculator calculator = new ReportCalculator();
            int wage = calculator.CalculateWage(report);

            //出力
            Console.WriteLine("社員名: " + report.EmployeeName);
            Console.WriteLine("勤務時間: " + report.HoursWorked);
            Console.WriteLine("給与: " + wage);

            //保存処理（ダミー）
            ReportSaver saver = new ReportSaver();
            saver.Save(report);
        }
    }
}
