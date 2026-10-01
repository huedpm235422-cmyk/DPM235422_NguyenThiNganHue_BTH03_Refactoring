using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceMethodWithMethodObject_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== REPLACE METHOD WITH METHOD OBJECT ===\n");

            var after = new Account_After();
            Console.WriteLine($"Kết quả Gamma (After): {after.Gamma(15, 10, 2026)}");

            Console.WriteLine();
            var real = new HoaDon_Real();
            real.TinhTienPhucTap(150000, 3, 50, 0.1);

            Console.ReadLine();
        }
    }
}
