using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeparateQueryFromModifier_Refactoring
{
    public class SeparateQueryFromModifier_Before
    {
        // Hàm vừa tìm người xấu (Query) vừa kích hoạt còi báo động (Modifier) -> Vi phạm nguyên tắc đơn trách nhiệm
        public string CheckSecurityAndAlert(string[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i] == "Kẻ gian")
                {
                    Console.WriteLine("Hú còi báo động!");
                    return "Kẻ gian";
                }
            }
            return "";
        }
    }
}
