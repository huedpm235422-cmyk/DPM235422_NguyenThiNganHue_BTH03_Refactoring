using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolidateConditional_Refactoring
{
    public class ConsolidateConditional_Real
    {
        // Thực tế: Xét duyệt hồ sơ vay vốn ngân hàng
        public void XetDuyetVayVon(int diemTinDung, double thuNhap, bool coNoXau)
        {
            if (KhongDuDieuKienVay(diemTinDung, thuNhap, coNoXau))
            {
                Console.WriteLine("[Thực tế] Hồ sơ bị TỪ CHỐI.");
                return;
            }
            Console.WriteLine("[Thực tế] Hồ sơ ĐƯỢC DUYỆT.");
        }

        private bool KhongDuDieuKienVay(int diemTinDung, double thuNhap, bool coNoXau)
        {
            return coNoXau || diemTinDung < 600 || thuNhap < 10000000;
        }
    }
}
