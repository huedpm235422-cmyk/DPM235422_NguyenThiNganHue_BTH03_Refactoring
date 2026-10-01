using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduceForeignMethod_Refactoring
{
    public class IntroduceForeignMethod_Real
    {
        public void TinhNgayHetHan()
        {
            DateTime ngaySanXuat = new DateTime(2026, 10, 1);
            // Sử dụng Foreign Method để cộng thêm 6 tháng
            DateTime ngayHetHan = CongThemThang(ngaySanXuat, 6);

            Console.WriteLine($"[Thực tế] Ngày sản xuất: {ngaySanXuat.ToShortDateString()} -> Hạn sử dụng: {ngayHetHan.ToShortDateString()}");
        }

        // Foreign Method hỗ trợ cho thư viện DateTime
        private static DateTime CongThemThang(DateTime date, int months)
        {
            return date.AddMonths(months);
        }
    }
}
