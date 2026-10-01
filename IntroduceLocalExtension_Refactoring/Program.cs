using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduceLocalExtension_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== INTRODUCE LOCAL EXTENSION ===\n");

            var after = new IntroduceLocalExtension_After();
            after.Process();

            Console.WriteLine();
            var real = new IntroduceLocalExtension_Real();
            real.InBaoGia();

            Console.ReadLine();
        }
    }
}
