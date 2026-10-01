using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveMiddleMan_Refactoring
{
    public class HoSoNhanSu
    {
        public string NgayVaoLam() => "01/01/2020";
        public string CapBac() => "Senior";
    }

    public class NhanVien
    {
        public HoSoNhanSu HoSo { get; } = new HoSoNhanSu();
        // Không tạo các hàm trung gian như LayCapBac() { return HoSo.CapBac(); } nữa
    }

    public class RemoveMiddleMan_Real
    {
        public void XemThongTin()
        {
            NhanVien nv = new NhanVien();
            // Client gọi trực tiếp qua HoSo
            Console.WriteLine($"[Thực tế] Cấp bậc: {nv.HoSo.CapBac()}, Ngày vào làm: {nv.HoSo.NgayVaoLam()}");
        }
    }
}
