using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceConstructorWithFactoryMethod_Refactoring
{
    public class GoiCuoc
    {
        public string TenGoi { get; set; }
        public double GiaTien { get; set; }

        private GoiCuoc(string ten, double gia)
        {
            TenGoi = ten;
            GiaTien = gia;
        }

        // Thực tế: Cung cấp các Factory Method có tên rõ ràng thay vì bắt Client gọi new GoiCuoc(...)
        public static GoiCuoc TaoGoiSinhVien()
        {
            return new GoiCuoc("Gói Sinh Viên", 50000);
        }

        public static GoiCuoc TaoGoiDoanhNghiep()
        {
            return new GoiCuoc("Gói Doanh Nghiệp VIP", 500000);
        }
    }
}
