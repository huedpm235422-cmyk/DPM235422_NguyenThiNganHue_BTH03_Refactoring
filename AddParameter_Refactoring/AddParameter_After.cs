using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddParameter_Refactoring
{
    public class AddParameter_After
    {
        // Thêm tham số 'isWeekend' để tính giá linh hoạt theo ngày cuối tuần
        public double GetPrice(bool isWeekend)
        {
            if (isWeekend)
            {
                return 120.0;
            }
            return 100.0;
        }
    }
}
