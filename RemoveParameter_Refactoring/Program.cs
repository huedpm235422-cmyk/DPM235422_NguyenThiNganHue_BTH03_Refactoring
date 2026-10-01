using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveParameter_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== REMOVE PARAMETER REFACTORING ===\n");

            var before = new RemoveParameter_Before();
            before.SendNotification("Thông báo họp lớp", "TXT");

            var after = new RemoveParameter_After();
            after.SendNotification("Thông báo họp lớp");

            var real = new RemoveParameter_Real();
            real.MoCuaPhongThiNghiem("DPM235422");

            Console.ReadLine();
        }
    }
}
