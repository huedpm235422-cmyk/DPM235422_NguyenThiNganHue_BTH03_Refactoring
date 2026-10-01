using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlineMethod_Refactoring
{
    public class InlineMethod_Real
    {
        public void XetDuyetMienPhiVanChuyen(double tongTienHoaDon)
        {
            // Trong thực tế, thay vì tạo 1 hàm KiemTraDieuKien() chỉ chứa mỗi phép toán > 500k,
            // ta đưa thẳng điều kiện vào if để code chạy nhanh và dễ đọc hơn.
            if (tongTienHoaDon >= 500000)
            {
                Console.WriteLine($"[Thực tế] Đơn hàng {tongTienHoaDon} VNĐ -> Đủ điều kiện FREESHIP.");
            }
            else
            {
                Console.WriteLine($"[Thực tế] Đơn hàng {tongTienHoaDon} VNĐ -> Tính phí vận chuyển bình thường.");
            }
        }
    }
}
