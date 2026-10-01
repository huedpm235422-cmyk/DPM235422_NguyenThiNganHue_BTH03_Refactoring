using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolidateDuplicateConditional_Refactoring
{
    public class ConsolidateDuplicateConditional_After
    {
        public void CalculateTotal(bool isSpecialDeal, double price)
        {
            double total;
            if (isSpecialDeal)
            {
                total = price * 0.95;
            }
            else
            {
                total = price * 0.98;
            }

            // Đưa lệnh chung ra ngoài
            Console.WriteLine("Đã gửi hóa đơn!");
            Console.WriteLine("Total (After): " + total);
        }
    }
}
