using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitTemporaryVariable_Refactoring
{
    public class SplitTemporaryVariable_Before
    {
        public void PrintGeometry(double height, double width)
        {
            // Biến temp bị dùng lại 2 lần cho 2 mục đích hoàn toàn khác nhau
            double temp = 2 * (height + width);
            Console.WriteLine("Chu vi (Before): " + temp);

            temp = height * width;
            Console.WriteLine("Diện tích (Before): " + temp);
        }
    }
}
