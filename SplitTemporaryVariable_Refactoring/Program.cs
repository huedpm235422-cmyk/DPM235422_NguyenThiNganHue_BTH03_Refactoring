using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitTemporaryVariable_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== SPLIT TEMPORARY VARIABLE ===\n");

            var after = new SplitTemporaryVariable_After();
            after.PrintGeometry(5, 10);

            Console.WriteLine();
            var real = new SplitTemporaryVariable_Real();
            real.XuLyThongTin("Nguyễn Thị Ngân Huế");

            Console.ReadLine();
        }
    }
}
