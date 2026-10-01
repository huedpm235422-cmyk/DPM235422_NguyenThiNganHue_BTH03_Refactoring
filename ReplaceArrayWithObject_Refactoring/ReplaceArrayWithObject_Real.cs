using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceArrayWithObject_Refactoring
{
    public class ThongTinBenhNhan
    {
        public string Ten { get; set; }
        public double CanNang { get; set; }
        public string NhomMau { get; set; }
    }

    public class ReplaceArrayWithObject_Real
    {
        public void HienThi()
        {
            // Thay vì dùng: string[] benhNhan = { "A", "65.5", "O" };
            var bn = new ThongTinBenhNhan { Ten = "Trần A", CanNang = 65.5, NhomMau = "O" };

            Console.WriteLine($"[Thực tế] Bệnh nhân: {bn.Ten} | Cân nặng: {bn.CanNang}kg | Máu: {bn.NhomMau}");
        }
    }
}
