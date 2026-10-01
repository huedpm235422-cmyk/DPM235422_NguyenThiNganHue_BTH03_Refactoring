using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceMethodWithMethodObject_Refactoring
{
    // Class ban đầu giờ trở nên cực kỳ gọn gàng
    public class Account_After
    {
        public int Gamma(int inputVal, int quantity, int yearToDate)
        {
            return new GammaCalculator(this, inputVal, quantity, yearToDate).Compute();
        }

        public int Delta() => 10;
    }

    // Tách hàm phức tạp thành một Class (Method Object) riêng biệt
    public class GammaCalculator
    {
        private Account_After _account;
        private int _inputVal;
        private int _quantity;
        private int _yearToDate;
        private int _importantValue1;
        private int _importantValue2;
        private int _importantValue3;

        public GammaCalculator(Account_After account, int inputVal, int quantity, int yearToDate)
        {
            _account = account;
            _inputVal = inputVal;
            _quantity = quantity;
            _yearToDate = yearToDate;
        }

        public int Compute()
        {
            _importantValue1 = (_inputVal * _quantity) + _account.Delta();
            _importantValue2 = (_inputVal * _yearToDate) + 100;

            if ((_yearToDate - _importantValue1) > 100)
            {
                _importantValue2 -= 20;
            }

            _importantValue3 = _importantValue2 * 7;
            return _importantValue3 - 2 * _importantValue1;
        }
    }
}
