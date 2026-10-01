using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolidateDuplicateConditional_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== CONSOLIDATE DUPLICATE CONDITIONAL ===\n");

            var after = new ConsolidateDuplicateConditional_After();
            after.CalculateTotal(true, 100);

            Console.WriteLine();
            var real = new ConsolidateDuplicateConditional_Real();
            real.XuLyDangNhap(false);

            Console.ReadLine();
        }
    }
}
