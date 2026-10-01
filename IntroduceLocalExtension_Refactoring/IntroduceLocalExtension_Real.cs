using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduceLocalExtension_Refactoring
{
    // Mở rộng trực tiếp cho kiểu double
    public static class DoubleExtensions
    {
        public static string ToVND(this double amount)
        {
            return amount.ToString("N0") + " VNĐ";
        }
    }

    public class IntroduceLocalExtension_Real
    {
        public void InBaoGia()
        {
            double giaMacBook = 35000000;

            // Thực tế: Cực kỳ tiện lợi khi thêm hậu tố tiền tệ
            Console.WriteLine($"[Thực tế] Giá máy: {giaMacBook.ToVND()}");
        }
    }
}
