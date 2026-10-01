using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreserveWholeObject_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== PRESERVE WHOLE OBJECT ===\n");

            var before = new PreserveWholeObject_Before();
            before.CheckWeather();

            var after = new PreserveWholeObject_After();
            after.CheckWeather();

            var real = new PreserveWholeObject_Real();
            real.XetDuyetTuyenDung();

            Console.ReadLine();
        }
    }
}
