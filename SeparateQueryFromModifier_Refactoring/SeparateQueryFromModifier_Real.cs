using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeparateQueryFromModifier_Refactoring
{
    public class SeparateQueryFromModifier_Real
    {
        private double _soDuTaiKhoan = 5000000;

        // Query: Kiểm tra xem đủ tiền rút không
        public bool KiemTraSoDuKhaDung(double soTienRut)
        {
            return _soDuTaiKhoan >= soTienRut;
        }

        // Modifier: Thực hiện trừ tiền
        public void TruTien(double soTienRut)
        {
            _soDuTaiKhoan -= soTienRut;
            Console.WriteLine($"[Thực tế] Đã trừ {soTienRut} VNĐ. Số dư còn lại: {_soDuTaiKhoan} VNĐ.");
        }
    }
}
