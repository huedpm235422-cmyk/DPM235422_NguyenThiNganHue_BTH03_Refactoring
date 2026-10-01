using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceParameterWithMethodCall_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== REPLACE PARAMETER WITH METHOD CALL ===\n");

            var after = new ReplaceParameterWithMethodCall_After();
            after.CalculatePrice();

            Console.WriteLine();
            var real = new ReplaceParameterWithMethodCall_Real();
            real.TinhLuongCuoiThang();

            Console.ReadLine();
        }
    }
}
