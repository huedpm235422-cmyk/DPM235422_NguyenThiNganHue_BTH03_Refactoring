using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideDelegate_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== HIDE DELEGATE REFACTORING ===\n");

            var clientBefore = new Client_Before();
            clientBefore.PrintManager();

            var clientAfter = new Client_After();
            clientAfter.PrintManager();

            Console.WriteLine();
            var real = new HideDelegate_Real();
            real.InThongTin();

            Console.ReadLine();
        }
    }
}
