using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceArrayWithObject_Refactoring
{
    // Tạo Class thay cho mảng
    public class PerformanceRow
    {
        public string Name { get; set; }
        public int Wins { get; set; }
    }

    public class ReplaceArrayWithObject_After
    {
        public void PrintRow()
        {
            var row = new PerformanceRow();
            row.Name = "Liverpool";
            row.Wins = 15; // Là số nguyên thật sự, không phải chuỗi

            Console.WriteLine($"Đội (After): {row.Name} - Thắng: {row.Wins}");
        }
    }
}
