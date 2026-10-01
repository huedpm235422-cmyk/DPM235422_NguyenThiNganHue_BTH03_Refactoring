using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlineMethod_Refactoring
{
    public class InlineMethod_After
    {
        private int _numberOfLateDeliveries = 6;

        public void GetRating()
        {
            // Inline thẳng logic vào đây cho gọn
            int rating = _numberOfLateDeliveries > 5 ? 2 : 1;
            Console.WriteLine($"Xếp hạng tài xế (After): {rating} sao");
        }
    }
}
