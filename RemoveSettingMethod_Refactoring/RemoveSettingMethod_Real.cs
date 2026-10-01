using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveSettingMethod_Refactoring
{
    public class NhanVien_Real
    {
        // Mã nhân viên là bất biến
        private readonly string _maNhanVien;
        public string Ten { get; set; } // Tên thì có thể thay đổi (Set)

        public NhanVien_Real(string maNV, string ten)
        {
            _maNhanVien = maNV;
            Ten = ten;
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"[Thực tế] Mã NV: {_maNhanVien} (Không thể sửa) | Tên: {Ten}");
        }
    }
}
