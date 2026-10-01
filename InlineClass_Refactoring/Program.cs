using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlineClass_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== INLINE CLASS REFACTORING ===\n");

            var after = new Person_After();
            Console.WriteLine("SĐT (After): " + after.GetTelephoneNumber());

            Console.WriteLine();
            var real = new DonHang_Real();
            real.InTrangThai();

            Console.ReadLine();
        }
    }
}
