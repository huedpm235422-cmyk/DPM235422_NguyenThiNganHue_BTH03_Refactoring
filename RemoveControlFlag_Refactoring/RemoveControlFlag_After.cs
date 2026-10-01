using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveControlFlag_Refactoring
{
    public class RemoveControlFlag_After
    {
        public void FindDon(string[] people)
        {
            foreach (var p in people)
            {
                if (p == "Don")
                {
                    Console.WriteLine("Tìm thấy Don! (After)");
                    break; // Dùng break trực tiếp, bỏ hẳn biến cờ
                }
            }
        }
    }
}
