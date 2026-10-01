using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceMagicNumberWithSymbolicConstant_Refactoring
{
    public class ReplaceMagicNumberWithSymbolicConstant_Before
    {
        public double PotentialEnergy(double mass, double height)
        {
            // Số 9.81 là "Magic Number", người khác nhìn vào không biết là gì
            return mass * height * 9.81;
        }
    }
}
