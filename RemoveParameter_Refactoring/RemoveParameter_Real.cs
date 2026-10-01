using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveParameter_Refactoring
{
    public class RemoveParameter_Real
    {
        // Thực tế: Hệ thống đổi sang quét vân tay nên không cần truyền mã PIN vào hàm mở cửa nữa
        public void MoCuaPhongThiNghiem(string maNhanVien)
        {
            Console.WriteLine($"[Thực tế] Xác thực mở cửa thành công cho nhân viên {maNhanVien} (đã bỏ mã PIN thừa).");
        }
    }
}
