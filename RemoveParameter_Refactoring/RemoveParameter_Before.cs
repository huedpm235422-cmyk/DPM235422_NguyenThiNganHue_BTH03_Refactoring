using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveParameter_Refactoring
{
    public class RemoveParameter_Before
    {
        // Tham số 'format' được truyền vào nhưng hoàn toàn không dùng trong hàm
        public void SendNotification(string message, string format)
        {
            Console.WriteLine("Gửi tin nhắn: " + message);
        }
    }
}
