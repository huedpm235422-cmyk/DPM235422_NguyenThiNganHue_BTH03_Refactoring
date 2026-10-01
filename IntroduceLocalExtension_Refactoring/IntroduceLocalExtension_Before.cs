using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduceLocalExtension_Refactoring
{
    public class IntroduceLocalExtension_Before
    {
        public void Process()
        {
            string dateStr = "2026-10-01";
            // Xử lý chuỗi rất dài dòng và thủ công ở nhiều nơi
            string formatted = dateStr.Replace("-", "/");
            Console.WriteLine("Ngày (Before): " + formatted);
        }
    }
}
