using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlineTemp_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== INLINE TEMP REFACTORING ===\n");

            var before = new InlineTemp_Before();
            before.CheckDiscount();

            var after = new InlineTemp_After();
            after.CheckDiscount();

            var real = new InlineTemp_Real();
            real.XetKhenThuongHocSinh(8.5, 9.0);

            Console.ReadLine();
        }
    }
}
