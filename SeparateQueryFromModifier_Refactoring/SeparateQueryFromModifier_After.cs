using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeparateQueryFromModifier_Refactoring
{
    public class SeparateQueryFromModifier_After
    {
        // Hàm 1: Chỉ làm nhiệm vụ truy vấn (Query)
        public string FindMiscreant(string[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i] == "Kẻ gian")
                {
                    return "Kẻ gian";
                }
            }
            return "";
        }

        // Hàm 2: Chỉ làm nhiệm vụ thay đổi trạng thái / hành động (Modifier)
        public void SendAlert()
        {
            Console.WriteLine("Hú còi báo động!");
        }
    }
}
