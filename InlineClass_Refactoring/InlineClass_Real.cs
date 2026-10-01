using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlineClass_Refactoring
{
    // Thực tế: Gộp thông tin theo dõi vận chuyển (TrackingInfo) vào thẳng Đơn hàng (Order) vì nó quá ít dữ liệu
    public class DonHang_Real
    {
        public string MaDonHang { get; set; } = "DH1001";

        // Thay vì tạo class TrackingInfo { HangVanChuyen, MaVanDon }, ta gộp thẳng vào:
        public string HangVanChuyen { get; set; } = "Giao Hàng Tiết Kiệm";
        public string MaVanDon { get; set; } = "GHTK_99998888";

        public void InTrangThai()
        {
            Console.WriteLine($"[Thực tế] Đơn {MaDonHang} đang giao qua {HangVanChuyen} (Mã VĐ: {MaVanDon})");
        }
    }
}
