using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTypeCodeWithClass_Refactoring
{
    public enum TrangThaiDonHang
    {
        MoiDat, DangXuLy, DaGiao, Huy
    }

    public class DonHang_Real
    {
        public TrangThaiDonHang TrangThai { get; set; }

        public void CapNhatTrangThai(TrangThaiDonHang trangThaiMoi)
        {
            TrangThai = trangThaiMoi;
            Console.WriteLine($"[Thực tế] Trạng thái đơn hàng hiện tại: {TrangThai}");
        }
    }
}
