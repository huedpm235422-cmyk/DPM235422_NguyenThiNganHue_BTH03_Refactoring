using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulateField_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== ENCAPSULATE FIELD REFACTORING ===\n");

            var after = new Person_After { Name = "Ngân Huế" };
            Console.WriteLine("Tên (After): " + after.Name);

            Console.WriteLine();
            var real = new TaiKhoanNganHang_Real();
            real.SoDu = 50000;
            Console.WriteLine($"[Thực tế] Số dư hiện tại: {real.SoDu}");

            // Thử gán số âm sẽ bị chặn nhờ Property
            real.SoDu = -1000;

            Console.ReadLine();
        }
    }
}
