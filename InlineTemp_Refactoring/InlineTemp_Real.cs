using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlineTemp_Refactoring
{
    public class InlineTemp_Real
    {
        public void XetKhenThuongHocSinh(double diemToan, double diemVan)
        {
            // Thay vì: double diemTrungBinh = TinhDiemTrungBinh(diemToan, diemVan);
            //           if (diemTrungBinh >= 8.0) ...
            // Ta đưa thẳng hàm tính toán vào if để tiết kiệm dòng code.

            if (TinhDiemTrungBinh(diemToan, diemVan) >= 8.0)
            {
                Console.WriteLine("[Thực tế] Học sinh đạt danh hiệu Học Sinh Giỏi. Thưởng 1.000.000 VNĐ.");
            }
            else
            {
                Console.WriteLine("[Thực tế] Học sinh không đủ điều kiện khen thưởng.");
            }
        }

        private double TinhDiemTrungBinh(double toan, double van)
        {
            return (toan + van) / 2.0;
        }
    }
}
