using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceArrayWithObject_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== REPLACE ARRAY WITH OBJECT ===\n");

            var after = new ReplaceArrayWithObject_After();
            after.PrintRow();

            Console.WriteLine();
            var real = new ReplaceArrayWithObject_Real();
            real.HienThi();

            Console.ReadLine();
        }
    }
}
