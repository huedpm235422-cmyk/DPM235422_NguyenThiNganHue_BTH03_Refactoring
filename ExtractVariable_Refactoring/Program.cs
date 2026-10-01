using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractVariable_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== EXTRACT VARIABLE REFACTORING ===\n");

            var before = new ExtractVariable_Before();
            before.CalculatePrice(600, 50.0);

            var after = new ExtractVariable_After();
            after.CalculatePrice(600, 50.0);

            var real = new ExtractVariable_Real();
            real.KiemTraTrinhDuyet("MacOS", "Safari", 1);

            Console.ReadLine();
        }
    }
}
