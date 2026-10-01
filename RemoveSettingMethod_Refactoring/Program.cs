using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveSettingMethod_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== REMOVE SETTING METHOD ===\n");

            var after = new Account_After("ACC-001");
            Console.WriteLine("Account ID: " + after.GetId());

            Console.WriteLine();
            var real = new NhanVien_Real("DPM235422", "Ngân Huế");
            real.HienThiThongTin();

            // real._maNhanVien = "Khac"; // Sẽ báo lỗi vì readonly

            Console.ReadLine();
        }
    }
}
