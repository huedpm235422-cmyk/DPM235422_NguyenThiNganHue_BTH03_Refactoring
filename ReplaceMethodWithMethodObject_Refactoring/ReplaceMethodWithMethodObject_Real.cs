using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceMethodWithMethodObject_Refactoring
{
    public class HoaDon_Real
    {
        public void TinhTienPhucTap(double donGia, int soLuong, int diemThuong, double phanTramGiam)
        {
            // Thay vì nhồi nhét công thức khổng lồ vào đây, ta đưa nó sang 1 class Calculator
            var boTinhToan = new BoTinhTienHoaDon(donGia, soLuong, diemThuong, phanTramGiam);
            double tienCuoiCung = boTinhToan.TinhToanThucTe();

            Console.WriteLine($"[Thực tế] Tiền thanh toán cuối cùng: {tienCuoiCung} VNĐ");
        }
    }

    // Class Method Object trong thực tế
    public class BoTinhTienHoaDon
    {
        private double _donGia;
        private int _soLuong;
        private int _diemThuong;
        private double _phanTramGiam;

        public BoTinhTienHoaDon(double donGia, int soLuong, int diemThuong, double phanTramGiam)
        {
            _donGia = donGia; _soLuong = soLuong; _diemThuong = diemThuong; _phanTramGiam = phanTramGiam;
        }

        public double TinhToanThucTe()
        {
            double tienCoBan = _donGia * _soLuong;
            double tienDuocGiam = tienCoBan * _phanTramGiam;
            double tienQuyDoiDiem = _diemThuong * 1000; // 1 điểm = 1000 VNĐ

            return Math.Max(0, tienCoBan - tienDuocGiam - tienQuyDoiDiem);
        }
    }
}
