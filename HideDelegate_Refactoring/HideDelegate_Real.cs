using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideDelegate_Refactoring
{
    public class KhoaDaiHoc
    {
        public string TruongKhoa { get; set; } = "Thầy Trần Văn A";
    }

    public class SinhVien
    {
        private KhoaDaiHoc _khoa = new KhoaDaiHoc();

        // Thực tế: Sinh viên giấu đi class Khoa, cung cấp hàm lấy Trưởng Khoa trực tiếp
        public string XemTruongKhoa()
        {
            return _khoa.TruongKhoa;
        }
    }

    public class HideDelegate_Real
    {
        public void InThongTin()
        {
            SinhVien sv = new SinhVien();
            // Không cần gọi: sv.GetKhoa().GetTruongKhoa()
            Console.WriteLine($"[Thực tế] Trưởng khoa của sinh viên là: {sv.XemTruongKhoa()}");
        }
    }
}
