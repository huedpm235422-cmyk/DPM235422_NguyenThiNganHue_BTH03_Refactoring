using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractMethod_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== 1. BEFORE REFACTORING ===");
            var before = new ExtractMethod_Before();
            before.PrintOwing("Ngân Huế", 500.0);

            Console.WriteLine("\n=== 2. AFTER REFACTORING ===");
            var after = new ExtractMethod_After();
            after.PrintOwing("Ngân Huế", 500.0);

            Console.WriteLine("\n=== 3. REAL WORD (ỨNG DỤNG) ===");
            var real = new ExtractMethod_Real();
            real.XuLyLuongNhanVien("Ngân Huế", 15000000, 2000000);

            Console.ReadLine();
        }
    }
}
