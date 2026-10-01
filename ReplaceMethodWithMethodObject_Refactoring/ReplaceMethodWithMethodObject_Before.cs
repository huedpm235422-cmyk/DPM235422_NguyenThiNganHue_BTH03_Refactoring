using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceMethodWithMethodObject_Refactoring
{
    public class Account_Before
    {
        // Hàm tính toán phức tạp, nhiều biến cục bộ
        public int Gamma(int inputVal, int quantity, int yearToDate)
        {
            int importantValue1 = (inputVal * quantity) + Delta();
            int importantValue2 = (inputVal * yearToDate) + 100;

            if ((yearToDate - importantValue1) > 100)
            {
                importantValue2 -= 20;
            }

            int importantValue3 = importantValue2 * 7;
            // ... có thể còn dài hơn nữa

            return importantValue3 - 2 * importantValue1;
        }

        public int Delta() => 10;
    }
}
