using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecomposeConditional_Refactoring
{
    public class DecomposeConditional_Before
    {
        private DateTime _summerStart = new DateTime(2026, 6, 1);
        private DateTime _summerEnd = new DateTime(2026, 8, 31);

        public void CalculateCharge(DateTime date, int quantity)
        {
            double charge;
            // Điều kiện if quá dài và khó đọc, thân lệnh cũng dính liền toán học
            if (date < _summerStart || date > _summerEnd)
            {
                charge = quantity * 1.5 + 20; // Phí mùa đông
            }
            else
            {
                charge = quantity * 1.0; // Phí mùa hè
            }
            Console.WriteLine($"Tính phí (Before): {charge}");
        }
    }
}
