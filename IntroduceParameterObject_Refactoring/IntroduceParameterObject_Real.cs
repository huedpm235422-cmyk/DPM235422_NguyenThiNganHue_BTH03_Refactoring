using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduceParameterObject_Refactoring
{
    // Gom nhóm các tham số tìm phòng khách sạn lại thành 1 yêu cầu (Request Object)
    public class BookingRequest
    {
        public string ThanhPho { get; set; }
        public DateTime NgayNhan { get; set; }
        public DateTime NgayTra { get; set; }
        public int SoNguoi { get; set; }

        public BookingRequest(string tp, DateTime nhan, DateTime tra, int nguoi)
        {
            ThanhPho = tp; NgayNhan = nhan; NgayTra = tra; SoNguoi = nguoi;
        }
    }

    public class IntroduceParameterObject_Real
    {
        // Thay vì: TimPhong(string thanhPho, DateTime nhan, DateTime tra, int nguoi)
        public void TimPhongKhachSan(BookingRequest request)
        {
            Console.WriteLine($"[Thực tế] Đang tìm phòng tại {request.ThanhPho} cho {request.SoNguoi} người...");
        }
    }
}
