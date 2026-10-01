using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveControlFlag_Refactoring
{
    public class RemoveControlFlag_Real
    {
        // Thực tế: Phần mềm diệt virus tìm file độc hại trong máy tính.
        // Chỉ cần thấy 1 file virus là dừng quét ngay lập tức để cách ly.
        public void QuetVirus(string[] danhSachFile)
        {
            foreach (var file in danhSachFile)
            {
                if (file.Contains("trojan") || file.Contains("virus"))
                {
                    Console.WriteLine($"[Thực tế] Cảnh báo! Phát hiện file mã độc: {file}. Đã cách ly và hủy quét.");
                    return; // Thoát hàm ngay lập tức, không cần cờ `hasVirus`
                }
                Console.WriteLine($"Quét an toàn: {file}");
            }
            Console.WriteLine("[Thực tế] Hệ thống an toàn.");
        }
    }
}
