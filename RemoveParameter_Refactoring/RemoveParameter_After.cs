using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveParameter_Refactoring
{
    public class RemoveParameter_After
    {
        // Đã xóa bỏ tham số 'format' thừa thãi
        public void SendNotification(string message)
        {
            Console.WriteLine("Gửi tin nhắn: " + message);
        }
    }
}
