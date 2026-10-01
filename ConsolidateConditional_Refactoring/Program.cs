using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolidateConditional_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== CONSOLIDATE CONDITIONAL ===\n");

            var after = new ConsolidateConditional_After();
            Console.WriteLine($"Lương hỗ trợ: {after.DisabilityAmount(3, 5, false)}");

            var real = new ConsolidateConditional_Real();
            real.XetDuyetVayVon(500, 15000000, false); // Bị từ chối do điểm tín dụng thấp

            Console.ReadLine();
        }
    }
}
