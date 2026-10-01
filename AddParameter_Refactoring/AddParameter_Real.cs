using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddParameter_Refactoring
{
    public class AddParameter_Real
    {
        // Thực tế: Hàm tính tiền điện được bổ sung thêm tham số 'phanTramThueVAT' để linh hoạt cập nhật thuế
        public double TinhTienDien(double soKwh, double donGia, double phanTramThueVAT)
        {
            double tienDienChuaThue = soKwh * donGia;
            return tienDienChuaThue + (tienDienChuaThue * phanTramThueVAT / 100.0);
        }
    }
}
