using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTypeCodeWithClass_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== REPLACE TYPE CODE WITH CLASS/ENUM ===\n");

            var after = new Person_After { BloodGroup = BloodGroup.A };
            Console.WriteLine("Nhóm máu (After): " + after.BloodGroup);

            Console.WriteLine();
            var real = new DonHang_Real();
            real.CapNhatTrangThai(TrangThaiDonHang.DangXuLy);

            Console.ReadLine();
        }
    }
}
