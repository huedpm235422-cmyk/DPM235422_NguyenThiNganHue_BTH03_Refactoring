using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreserveWholeObject_Refactoring
{
    public class TempRange
    {
        public int Low { get; set; } = 15;
        public int High { get; set; } = 35;
    }

    public class PreserveWholeObject_Before
    {
        public void CheckWeather()
        {
            TempRange daysTempRange = new TempRange();

            // Lấy lắt nhắt từng thuộc tính ra để truyền
            int low = daysTempRange.Low;
            int high = daysTempRange.High;

            bool isWithinPlan = WithinPlan(low, high);
            Console.WriteLine("Thời tiết có hợp lý không? (Before): " + isWithinPlan);
        }

        private bool WithinPlan(int low, int high)
        {
            return (low >= 10 && high <= 40);
        }
    }
}
