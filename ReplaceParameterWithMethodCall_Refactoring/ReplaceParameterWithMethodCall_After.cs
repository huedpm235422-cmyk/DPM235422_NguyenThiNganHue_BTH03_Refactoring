using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceParameterWithMethodCall_Refactoring
{
    public class ReplaceParameterWithMethodCall_After
    {
        public void CalculatePrice()
        {
            int basePrice = 100;
            // Không cần tính trước, gọi thẳng hàm và tự nó lấy discount
            double finalPrice = DiscountedPrice(basePrice);

            Console.WriteLine("Giá cuối (After): " + finalPrice);
        }

        private double GetDiscountLevel() => 0.1;

        private double DiscountedPrice(int basePrice)
        {
            // Tự gọi hàm lấy discount ở bên trong
            return basePrice - (basePrice * GetDiscountLevel());
        }
    }
}
