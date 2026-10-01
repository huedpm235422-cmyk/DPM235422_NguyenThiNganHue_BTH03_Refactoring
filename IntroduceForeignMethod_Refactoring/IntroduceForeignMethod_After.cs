using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduceForeignMethod_Refactoring
{
    public class IntroduceForeignMethod_After
    {
        public void CheckDate()
        {
            DateTime previousEnd = new DateTime(2026, 10, 1);

            // Gọi hàm Foreign Method để code gọn gàng
            DateTime newStart = NextDay(previousEnd);

            Console.WriteLine("Ngày tiếp theo (After): " + newStart.ToShortDateString());
        }

        // Tạo Foreign Method ngay trong class gọi nó
        private static DateTime NextDay(DateTime arg)
        {
            return new DateTime(arg.Year, arg.Month, arg.Day + 1);
        }
    }
}
