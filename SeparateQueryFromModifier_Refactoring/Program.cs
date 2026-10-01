using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeparateQueryFromModifier_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== SEPARATE QUERY FROM MODIFIER ===\n");

            string[] danhSach = { "Khách A", "Kẻ gian", "Khách B" };

            var before = new SeparateQueryFromModifier_Before();
            before.CheckSecurityAndAlert(danhSach);

            Console.WriteLine();
            var after = new SeparateQueryFromModifier_After();
            string phatHien = after.FindMiscreant(danhSach);
            if (!string.IsNullOrEmpty(phatHien))
            {
                after.SendAlert();
            }

            Console.WriteLine();
            var real = new SeparateQueryFromModifier_Real();
            if (real.KiemTraSoDuKhaDung(2000000))
            {
                real.TruTien(2000000);
            }

            Console.ReadLine();
        }
    }
}
