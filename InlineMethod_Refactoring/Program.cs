using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlineMethod_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== INLINE METHOD REFACTORING ===\n");

            var before = new InlineMethod_Before();
            before.GetRating();

            var after = new InlineMethod_After();
            after.GetRating();

            var real = new InlineMethod_Real();
            real.XetDuyetMienPhiVanChuyen(600000);

            Console.ReadLine();
        }
    }
}
