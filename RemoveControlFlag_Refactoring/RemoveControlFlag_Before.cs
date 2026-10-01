using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveControlFlag_Refactoring
{
    public class RemoveControlFlag_Before
    {
        public void FindDon(string[] people)
        {
            bool found = false; // Biến cờ (Control Flag)
            foreach (var p in people)
            {
                if (!found)
                {
                    if (p == "Don")
                    {
                        Console.WriteLine("Tìm thấy Don! (Before)");
                        found = true; // Set cờ để dừng vòng lặp
                    }
                }
            }
        }
    }
}
