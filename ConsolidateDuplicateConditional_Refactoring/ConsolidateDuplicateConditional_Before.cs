using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolidateDuplicateConditional_Refactoring
{
    public class ConsolidateDuplicateConditional_Before
    {
        public void CalculateTotal(bool isSpecialDeal, double price)
        {
            double total;
            if (isSpecialDeal)
            {
                total = price * 0.95;
                Console.WriteLine("Đã gửi hóa đơn!"); // Bị lặp lại
            }
            else
            {
                total = price * 0.98;
                Console.WriteLine("Đã gửi hóa đơn!"); // Bị lặp lại
            }
            Console.WriteLine("Total (Before): " + total);
        }
    }
}
