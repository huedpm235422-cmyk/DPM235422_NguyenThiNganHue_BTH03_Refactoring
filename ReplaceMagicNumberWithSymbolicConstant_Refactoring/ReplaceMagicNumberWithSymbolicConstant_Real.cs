using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceMagicNumberWithSymbolicConstant_Refactoring
{
    public class ReplaceMagicNumberWithSymbolicConstant_Real
    {
        // Thực tế: Các mức phí, thuế được khai báo thành Hằng số ở đầu class
        private const double THUE_VAT = 0.08; // Thuế 8%
        private const double PHI_DICH_VU = 30000;

        public void TinhTienDatPhong(double giaPhong)
        {
            double tienThue = giaPhong * THUE_VAT;
            double tongTien = giaPhong + tienThue + PHI_DICH_VU;

            Console.WriteLine($"[Thực tế] Tổng tiền (đã gồm VAT và Phí DV): {tongTien} VNĐ");
        }
    }
}
