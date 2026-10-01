using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduceLocalExtension_Refactoring
{
    // Tạo class mở rộng tĩnh (Local Extension) trong C#
    public static class StringExtensions
    {
        // Hàm mở rộng (có từ khóa 'this')
        public static string ToSlashFormat(this string str)
        {
            return str.Replace("-", "/");
        }
    }

    public class IntroduceLocalExtension_After
    {
        public void Process()
        {
            string dateStr = "2026-10-01";
            // Sử dụng hàm mở rộng như thể nó là hàm có sẵn của string
            Console.WriteLine("Ngày (After): " + dateStr.ToSlashFormat());
        }
    }
}
