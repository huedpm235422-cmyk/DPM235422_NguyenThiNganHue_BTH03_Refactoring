using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlineMethod_Refactoring
{
    public class InlineMethod_Before
    {
        private int _numberOfLateDeliveries = 6;

        public void GetRating()
        {
            int rating = MoreThanFiveLateDeliveries() ? 2 : 1;
            Console.WriteLine($"Xếp hạng tài xế (Before): {rating} sao");
        }

        // Hàm này quá đơn giản, không cần thiết phải tách riêng
        private bool MoreThanFiveLateDeliveries()
        {
            return _numberOfLateDeliveries > 5;
        }
    }
}
