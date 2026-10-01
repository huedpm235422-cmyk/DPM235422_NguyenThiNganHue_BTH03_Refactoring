using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceNestedConditionalWithGuardClauses_Refactoring
{
    public class ReplaceNestedConditionalWithGuardClauses_Real
    {
        // Thực tế: Kiểm tra điều kiện mua vé xem phim 18+
        public void MuaVeXemPhim(int tuoi, bool hetVe, double tienKhachDua)
        {
            // Các Guard Clauses chặn lỗi ngay từ đầu
            if (tuoi < 18)
            {
                Console.WriteLine("[Thực tế] Bán vé thất bại: Khách chưa đủ 18 tuổi.");
                return;
            }

            if (hetVe)
            {
                Console.WriteLine("[Thực tế] Bán vé thất bại: Rạp đã hết vé.");
                return;
            }

            if (tienKhachDua < 100000)
            {
                Console.WriteLine("[Thực tế] Bán vé thất bại: Khách đưa không đủ tiền.");
                return;
            }

            // Luồng thành công nằm dưới cùng, cực kỳ dễ đọc
            Console.WriteLine("[Thực tế] Bán vé THÀNH CÔNG! Chúc quý khách xem phim vui vẻ.");
        }
    }
}
