using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractClass_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== EXTRACT CLASS REFACTORING ===\n");

            var before = new Person_Before();
            Console.WriteLine("SDT (Before): " + before.GetTelephoneNumber());

            var after = new Person_After();
            Console.WriteLine("SDT (After): " + after.OfficeTelephone.GetTelephoneNumber());

            Console.WriteLine();
            var real = new ExtractClass_Real();
            real.HienThi();

            Console.ReadLine();
        }
    }
}
