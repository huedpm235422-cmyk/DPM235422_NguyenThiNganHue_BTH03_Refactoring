using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractClass_Refactoring
{
    // Thực tế: Tách riêng phần "Địa chỉ" khỏi "Nhân viên"
    public class DiaChi
    {
        public string Duong { get; set; } = "Ung Văn Khiêm";
        public string Quan { get; set; } = "Bình Thạnh";
        public string ThanhPho { get; set; } = "TP.HCM";

        public string InDiaChi() => $"{Duong}, {Quan}, {ThanhPho}";
    }

    public class NhanVien
    {
        public string Ten { get; set; } = "Ngân Huế";
        public DiaChi DiaChiThuongTru { get; set; } = new DiaChi();
    }

    public class ExtractClass_Real
    {
        public void HienThi()
        {
            NhanVien nv = new NhanVien();
            Console.WriteLine($"[Thực tế] Nhân viên: {nv.Ten}");
            Console.WriteLine($"[Thực tế] Nơi ở: {nv.DiaChiThuongTru.InDiaChi()}");
        }
    }
}
