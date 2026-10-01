using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractVariable_Refactoring
{
    public class ExtractVariable_Real
    {
        public void KiemTraTrinhDuyet(string platform, string browser, int initTime)
        {
            // Ứng dụng thực tế: Tách điều kiện if phức tạp thành biến cờ (flag)
            bool isMacOs = platform.ToUpper().Contains("MAC");
            bool isSafari = browser.ToUpper().Contains("SAFARI");
            bool wasInitialized = initTime > 0;

            bool isReadyForMacRender = isMacOs && isSafari && wasInitialized;

            if (isReadyForMacRender)
            {
                Console.WriteLine("[Thực tế] Khởi tạo giao diện riêng cho hệ điều hành MacOS thành công.");
            }
            else
            {
                Console.WriteLine("[Thực tế] Sử dụng giao diện mặc định.");
            }
        }
    }
}
