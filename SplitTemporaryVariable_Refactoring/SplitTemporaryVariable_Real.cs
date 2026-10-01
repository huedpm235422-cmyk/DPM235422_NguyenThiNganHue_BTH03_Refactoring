using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitTemporaryVariable_Refactoring
{
    public class SplitTemporaryVariable_Real
    {
        // Thực tế: Xử lý chuỗi thông tin người dùng
        public void XuLyThongTin(string hoTen)
        {
            // Thay vì dùng 1 biến 'ketQua' cập nhật liên tục, ta tách riêng từng biến
            string tenInHoa = hoTen.ToUpper();
            Console.WriteLine($"[Thực tế] Tên in hoa: {tenInHoa}");

            int doDaiTen = hoTen.Replace(" ", "").Length;
            Console.WriteLine($"[Thực tế] Số lượng ký tự chữ cái: {doDaiTen}");
        }
    }
}
