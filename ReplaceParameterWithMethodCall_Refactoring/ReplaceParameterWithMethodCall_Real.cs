using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceParameterWithMethodCall_Refactoring
{
    public class ReplaceParameterWithMethodCall_Real
    {
        public void TinhLuongCuoiThang()
        {
            double luongCoBan = 10000000;
            // Hàm TinhThucLanh tự gọi hàm LayMucPhatTre() bên trong nó
            double thucLanh = TinhThucLanh(luongCoBan);

            Console.WriteLine($"[Thực tế] Thực lãnh cuối tháng: {thucLanh} VNĐ");
        }

        private double LayMucPhatTre() => 500000; // Phạt đi trễ

        private double TinhThucLanh(double luongCoBan)
        {
            return luongCoBan - LayMucPhatTre();
        }
    }
}
