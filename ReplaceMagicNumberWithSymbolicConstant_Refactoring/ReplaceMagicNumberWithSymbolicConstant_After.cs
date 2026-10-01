using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceMagicNumberWithSymbolicConstant_Refactoring
{
    public class ReplaceMagicNumberWithSymbolicConstant_After
    {
        // Đặt tên Hằng số rõ ràng, sau này cần đổi chỉ cần đổi 1 chỗ
        private const double GRAVITATIONAL_CONSTANT = 9.81;

        public double PotentialEnergy(double mass, double height)
        {
            return mass * height * GRAVITATIONAL_CONSTANT;
        }
    }
}
