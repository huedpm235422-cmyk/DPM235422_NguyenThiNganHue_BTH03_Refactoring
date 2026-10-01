using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceConstructorWithFactoryMethod_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== REPLACE CONSTRUCTOR WITH FACTORY METHOD ===\n");

            var emp = Employee_After.Create(1);
            Console.WriteLine("Loại NV (After): " + emp.Type);

            Console.WriteLine();
            var goiSinhVien = GoiCuoc.TaoGoiSinhVien();
            var goiVIP = GoiCuoc.TaoGoiDoanhNghiep();

            Console.WriteLine($"[Thực tế] Đã đăng ký: {goiSinhVien.TenGoi} - Giá: {goiSinhVien.GiaTien}");
            Console.WriteLine($"[Thực tế] Đã đăng ký: {goiVIP.TenGoi} - Giá: {goiVIP.GiaTien}");

            Console.ReadLine();
        }
    }
}
