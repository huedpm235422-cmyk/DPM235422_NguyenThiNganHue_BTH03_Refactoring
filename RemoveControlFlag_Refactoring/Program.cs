using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveControlFlag_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== REMOVE CONTROL FLAG ===\n");

            string[] names = { "John", "Peter", "Don", "Sarah" };

            var after = new RemoveControlFlag_After();
            after.FindDon(names);

            Console.WriteLine();
            string[] files = { "hinh_anh.jpg", "tai_lieu.docx", "trojan_bank.exe", "game.exe" };
            var real = new RemoveControlFlag_Real();
            real.QuetVirus(files);

            Console.ReadLine();
        }
    }
}
