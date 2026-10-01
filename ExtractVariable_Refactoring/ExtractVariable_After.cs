using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractVariable_Refactoring
{
    public class ExtractVariable_After
    {
        public void CalculatePrice(int quantity, double itemPrice)
        {
            // Đã tách thành các biến giải thích ý nghĩa rõ ràng
            double basePrice = quantity * itemPrice;
            double quantityDiscount = Math.Max(0, quantity - 500) * itemPrice * 0.05;
            double shipping = Math.Min(basePrice * 0.1, 100.0);

            double finalPrice = basePrice - quantityDiscount + shipping;

            Console.WriteLine($"Giá trị đơn hàng (After): {finalPrice}");
        }
    }
}
