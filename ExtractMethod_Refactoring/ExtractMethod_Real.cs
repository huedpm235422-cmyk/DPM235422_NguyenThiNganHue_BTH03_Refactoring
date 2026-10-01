using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractMethod_Refactoring
{
    public class ExtractMethod_Real
    {
        // Hàm chính gọi các hàm đã được tách ra cho gọn gàng
        public void XuLyLuongNhanVien(string tenNhanVien, double luongCoBan, double thuong)
        {
            InTieuDe();
            double thucLanh = TinhTongLuong(luongCoBan, thuong);
            InBienLai(tenNhanVien, thucLanh);
        }

        private void InTieuDe()
        {
            Console.WriteLine("--- BIÊN LAI LƯƠNG THÁNG ---");
        }

        private double TinhTongLuong(double luongCoBan, double thuong)
        {
            return luongCoBan + thuong;
        }

        private void InBienLai(string ten, double thucLanh)
        {
            Console.WriteLine($"Nhân viên: {ten} | Thực lãnh: {thucLanh} VNĐ\n");
        }
    }
}
