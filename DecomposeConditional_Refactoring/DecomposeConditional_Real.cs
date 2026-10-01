using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecomposeConditional_Refactoring
{
    public class DecomposeConditional_Real
    {
        // Thực tế: Tính tiền vé máy bay, tách điều kiện ngày lễ tết ra hàm riêng
        public void TinhGiaVe(DateTime ngayBay, double giaGoc)
        {
            if (LaNgayLeTet(ngayBay))
            {
                Console.WriteLine($"[Thực tế] Giá vé dịp Lễ: {PhuThuNgayLe(giaGoc)} VNĐ");
            }
            else
            {
                Console.WriteLine($"[Thực tế] Giá vé ngày thường: {giaGoc} VNĐ");
            }
        }

        private bool LaNgayLeTet(DateTime ngay) => (ngay.Month == 1 || ngay.Month == 2 || (ngay.Day == 30 && ngay.Month == 4));
        private double PhuThuNgayLe(double giaGoc) => giaGoc * 1.3;
    }
}
