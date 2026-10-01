using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecomposeConditional_Refactoring
{
    public class DecomposeConditional_After
    {
        private DateTime _summerStart = new DateTime(2026, 6, 1);
        private DateTime _summerEnd = new DateTime(2026, 8, 31);

        public void CalculateCharge(DateTime date, int quantity)
        {
            // Code đọc như ngôn ngữ tự nhiên
            double charge = IsNotSummer(date) ? WinterCharge(quantity) : SummerCharge(quantity);
            Console.WriteLine($"Tính phí (After): {charge}");
        }

        private bool IsNotSummer(DateTime date) => date < _summerStart || date > _summerEnd;
        private double WinterCharge(int quantity) => quantity * 1.5 + 20;
        private double SummerCharge(int quantity) => quantity * 1.0;
    }
}
