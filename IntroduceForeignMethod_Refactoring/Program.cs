using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduceForeignMethod_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== INTRODUCE FOREIGN METHOD ===\n");

            var after = new IntroduceForeignMethod_After();
            after.CheckDate();

            Console.WriteLine();
            var real = new IntroduceForeignMethod_Real();
            real.TinhNgayHetHan();

            Console.ReadLine();
        }
    }
}
