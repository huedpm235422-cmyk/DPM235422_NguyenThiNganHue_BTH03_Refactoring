using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduceParameterObject_Refactoring
{
    public class DateRange
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateRange(DateTime start, DateTime end) { Start = start; End = end; }
    }

    public class IntroduceParameterObject_After
    {
        // Thay 2 tham số rời rạc bằng 1 Object
        public void AmountInvoicedIn(DateRange dateRange)
        {
            Console.WriteLine($"Hóa đơn từ {dateRange.Start.ToShortDateString()} đến {dateRange.End.ToShortDateString()}");
        }
    }
}
