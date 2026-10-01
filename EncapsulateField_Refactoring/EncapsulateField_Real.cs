using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulateField_Refactoring
{
    public class TaiKhoanNganHang_Real
    {
        private double _soDu;

        // Đóng gói: Chặn việc gán số dư âm
        public double SoDu
        {
            get { return _soDu; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("[Thực tế] Lỗi: Số dư không thể âm!");
                }
                else
                {
                    _soDu = value;
                }
            }
        }
    }
}
