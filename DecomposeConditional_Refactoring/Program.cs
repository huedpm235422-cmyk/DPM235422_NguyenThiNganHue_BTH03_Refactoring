using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecomposeConditional_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== DECOMPOSE CONDITIONAL ===\n");

            var before = new DecomposeConditional_Before();
            before.CalculateCharge(new DateTime(2026, 7, 15), 10);

            var after = new DecomposeConditional_After();
            after.CalculateCharge(new DateTime(2026, 7, 15), 10);

            var real = new DecomposeConditional_Real();
            real.TinhGiaVe(new DateTime(2026, 4, 30), 2000000);

            Console.ReadLine();
        }
    }
}
