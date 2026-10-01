using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlineTemp_Refactoring
{
    public class InlineTemp_Before
    {
        public void CheckDiscount()
        {
            // Biến tạm basePrice là dư thừa vì hàm GetBasePrice() đã quá rõ nghĩa
            double basePrice = GetBasePrice();
            bool hasDiscount = basePrice > 1000;

            Console.WriteLine($"Có được giảm giá không? (Before): {hasDiscount}");
        }

        private double GetBasePrice() { return 1200; }
    }
}
