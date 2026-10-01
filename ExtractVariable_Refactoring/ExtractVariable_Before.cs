using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractVariable_Refactoring
{
    public class ExtractVariable_Before
    {
        public void CalculatePrice(int quantity, double itemPrice)
        {
            // Biểu thức tính tiền dài ngoằng, khó hiểu
            double price = quantity * itemPrice - Math.Max(0, quantity - 500) * itemPrice * 0.05 + Math.Min(quantity * itemPrice * 0.1, 100.0);

            Console.WriteLine($"Giá trị đơn hàng (Before): {price}");
        }
    }
}
