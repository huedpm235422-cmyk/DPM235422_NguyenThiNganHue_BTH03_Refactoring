using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlineTemp_Refactoring
{
    public class InlineTemp_After
    {
        public void CheckDiscount()
        {
            // Inline thẳng hàm vào điều kiện logic
            bool hasDiscount = GetBasePrice() > 1000;

            Console.WriteLine($"Có được giảm giá không? (After): {hasDiscount}");
        }

        private double GetBasePrice() { return 1200; }
    }
}
