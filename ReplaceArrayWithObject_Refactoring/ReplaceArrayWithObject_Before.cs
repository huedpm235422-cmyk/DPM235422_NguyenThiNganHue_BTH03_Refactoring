using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceArrayWithObject_Refactoring
{
    public class ReplaceArrayWithObject_Before
    {
        public void PrintRow()
        {
            // Dùng mảng string để lưu nhiều kiểu dữ liệu -> Khó quản lý
            string[] row = new string[3];
            row[0] = "Liverpool"; // Tên đội
            row[1] = "15";        // Số trận thắng

            Console.WriteLine($"Đội: {row[0]} - Thắng: {row[1]}");
        }
    }
}
