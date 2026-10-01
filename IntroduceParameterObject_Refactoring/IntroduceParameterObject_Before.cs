using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduceParameterObject_Refactoring
{
    public class IntroduceParameterObject_Before
    {
        // Nhận vào 2 tham số ngày tháng rời rạc
        public void AmountInvoicedIn(DateTime start, DateTime end)
        {
            Console.WriteLine($"Hóa đơn từ {start.ToShortDateString()} đến {end.ToShortDateString()}");
        }
    }
}
