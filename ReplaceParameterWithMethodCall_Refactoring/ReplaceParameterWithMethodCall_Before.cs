using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceParameterWithMethodCall_Refactoring
{
    public class ReplaceParameterWithMethodCall_Before
    {
        public void CalculatePrice()
        {
            int basePrice = 100;
            // Tính phí giảm giá rồi mới truyền vào hàm
            double discountLevel = GetDiscountLevel();
            double finalPrice = DiscountedPrice(basePrice, discountLevel);

            Console.WriteLine("Giá cuối (Before): " + finalPrice);
        }

        private double GetDiscountLevel() => 0.1; // Giảm 10%

        private double DiscountedPrice(int basePrice, double discountLevel)
        {
            return basePrice - (basePrice * discountLevel);
        }
    }
}
