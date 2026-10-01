using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceNestedConditionalWithGuardClauses_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== REPLACE NESTED CONDITIONAL WITH GUARD CLAUSES ===\n");

            var after = new ReplaceNestedConditionalWithGuardClauses_After();
            Console.WriteLine($"Lương nhân viên nghỉ hưu: {after.GetPayAmount(false, false, true)}");

            Console.WriteLine();
            var real = new ReplaceNestedConditionalWithGuardClauses_Real();
            real.MuaVeXemPhim(20, false, 50000); // Thất bại do thiếu tiền

            Console.ReadLine();
        }
    }
}
