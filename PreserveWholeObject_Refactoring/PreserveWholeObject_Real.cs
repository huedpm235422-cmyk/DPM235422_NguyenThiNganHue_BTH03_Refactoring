using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreserveWholeObject_Refactoring
{
    public class UngVien
    {
        public int KiemTraToiec { get; set; } = 600;
        public int NamKinhNghiem { get; set; } = 3;
    }

    public class PreserveWholeObject_Real
    {
        public void XetDuyetTuyenDung()
        {
            UngVien uv = new UngVien();

            // Thay vì truyền: XetDuyet(uv.KiemTraToiec, uv.NamKinhNghiem)
            // Ta truyền thẳng đối tượng Ứng Viên vào:
            bool ketQua = XetDuyet(uv);

            Console.WriteLine($"[Thực tế] Ứng viên đậu phỏng vấn không? {ketQua}");
        }

        private bool XetDuyet(UngVien uv)
        {
            return uv.KiemTraToiec >= 550 && uv.NamKinhNghiem >= 2;
        }
    }
}
