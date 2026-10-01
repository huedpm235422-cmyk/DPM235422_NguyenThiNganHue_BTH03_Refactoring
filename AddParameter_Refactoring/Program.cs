using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddParameter_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== ADD PARAMETER REFACTORING ===\n");

            var before = new AddParameter_Before();
            Console.WriteLine("Giá (Before): " + before.GetPrice());

            var after = new AddParameter_After();
            Console.WriteLine("Giá cuối tuần (After): " + after.GetPrice(true));

            var real = new AddParameter_Real();
            double tongTien = real.TinhTienDien(150, 2500, 10);
            Console.WriteLine($"[Thực tế] Tiền điện tiêu thụ (đã thêm thuế VAT): {tongTien} VNĐ");

            Console.ReadLine();
        }
    }
}
