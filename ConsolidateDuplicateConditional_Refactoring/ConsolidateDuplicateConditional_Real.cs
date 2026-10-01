using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolidateDuplicateConditional_Refactoring
{
    public class ConsolidateDuplicateConditional_Real
    {
        // Thực tế: Dù đăng nhập thành công hay thất bại thì đều phải lưu lịch sử (Ghi log)
        public void XuLyDangNhap(bool dungMatKhau)
        {
            if (dungMatKhau)
            {
                Console.WriteLine("[Thực tế] Đăng nhập thành công. Mở màn hình chính.");
            }
            else
            {
                Console.WriteLine("[Thực tế] Sai mật khẩu. Hiển thị thông báo lỗi.");
            }

            // Rút gọn: Bỏ vào nhánh if-else sẽ bị lặp, đưa ra ngoài
            Console.WriteLine("[Thực tế] -> System Log: Ghi nhận 1 lượt truy cập lúc " + DateTime.Now.ToString("HH:mm:ss"));
        }
    }
}
