using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddParameter_Refactoring
{
    public class AddParameter_Before
    {
        // Ban đầu hàm chỉ tính giá cố định mà không cho truyền ngày vào
        public double GetPrice()
        {
            return 100.0;
        }
    }
}
