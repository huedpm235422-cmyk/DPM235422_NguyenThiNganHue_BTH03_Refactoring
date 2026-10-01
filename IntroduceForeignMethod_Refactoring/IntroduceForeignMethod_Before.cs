using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduceForeignMethod_Refactoring
{
    public class IntroduceForeignMethod_Before
    {
        public void CheckDate()
        {
            DateTime previousEnd = new DateTime(2026, 10, 1);

            // Xử lý trực tiếp, lặp lại nhiều lần nếu cần tính ngày tiếp theo
            DateTime newStart = new DateTime(previousEnd.Year, previousEnd.Month, previousEnd.Day + 1);

            Console.WriteLine("Ngày tiếp theo (Before): " + newStart.ToShortDateString());
        }
    }
}
