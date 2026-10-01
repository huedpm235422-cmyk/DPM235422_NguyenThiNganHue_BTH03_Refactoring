using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduceParameterObject_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== INTRODUCE PARAMETER OBJECT ===\n");

            var after = new IntroduceParameterObject_After();
            after.AmountInvoicedIn(new DateRange(new DateTime(2026, 10, 1), new DateTime(2026, 10, 31)));

            Console.WriteLine();
            var real = new IntroduceParameterObject_Real();
            real.TimPhongKhachSan(new BookingRequest("Đà Lạt", DateTime.Now, DateTime.Now.AddDays(2), 2));

            Console.ReadLine();
        }
    }
}
