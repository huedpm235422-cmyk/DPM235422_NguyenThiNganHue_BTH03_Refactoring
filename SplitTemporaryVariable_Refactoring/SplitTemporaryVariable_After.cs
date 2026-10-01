using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitTemporaryVariable_Refactoring
{
    public class SplitTemporaryVariable_After
    {
        public void PrintGeometry(double height, double width)
        {
            // Tách thành 2 biến riêng biệt để tránh nhầm lẫn
            double perimeter = 2 * (height + width);
            Console.WriteLine("Chu vi (After): " + perimeter);

            double area = height * width;
            Console.WriteLine("Diện tích (After): " + area);
        }
    }
}
