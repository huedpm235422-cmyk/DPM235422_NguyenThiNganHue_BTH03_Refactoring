using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceMagicNumberWithSymbolicConstant_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== REPLACE MAGIC NUMBER WITH SYMBOLIC CONSTANT ===\n");

            var after = new ReplaceMagicNumberWithSymbolicConstant_After();
            Console.WriteLine($"Thế năng (After): {after.PotentialEnergy(5, 10)}");

            var real = new ReplaceMagicNumberWithSymbolicConstant_Real();
            real.TinhTienDatPhong(500000);

            Console.ReadLine();
        }
    }
}
