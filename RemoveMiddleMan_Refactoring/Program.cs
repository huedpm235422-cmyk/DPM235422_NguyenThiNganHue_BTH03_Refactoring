using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveMiddleMan_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== REMOVE MIDDLE MAN REFACTORING ===\n");

            var before = new Person_Before();
            Console.WriteLine("Phòng ban (Before): " + before.GetDepartmentName());

            var after = new Person_After();
            Console.WriteLine("Phòng ban (After): " + after.GetDepartment().GetName());

            Console.WriteLine();
            var real = new RemoveMiddleMan_Real();
            real.XemThongTin();

            Console.ReadLine();
        }
    }
}
