using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreserveWholeObject_Refactoring
{
    public class PreserveWholeObject_After
    {
        public void CheckWeather()
        {
            TempRange daysTempRange = new TempRange();

            // Truyền nguyên đối tượng vào hàm
            bool isWithinPlan = WithinPlan(daysTempRange);
            Console.WriteLine("Thời tiết có hợp lý không? (After): " + isWithinPlan);
        }

        // Hàm nhận trực tiếp đối tượng
        private bool WithinPlan(TempRange range)
        {
            return (range.Low >= 10 && range.High <= 40);
        }
    }
}
