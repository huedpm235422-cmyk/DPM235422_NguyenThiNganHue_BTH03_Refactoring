using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenameMethod_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== RENAME METHOD REFACTORING ===\n");

            var before = new RenameMethod_Before();
            Console.WriteLine("Tên (Before): " + before.GetNm());

            var after = new RenameMethod_After();
            Console.WriteLine("Tên (After): " + after.GetFullName());

            var real = new RenameMethod_Real();
            bool daHetHan = real.KiemTraHetHanSuDung(new DateTime(2023, 1, 1));
            Console.WriteLine("[Thực tế] Sản phẩm đã hết hạn chưa: " + daHetHan);

            Console.ReadLine();
        }
    }
}
