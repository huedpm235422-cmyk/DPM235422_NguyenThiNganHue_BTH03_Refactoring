using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolidateConditional_Refactoring
{
    public class ConsolidateConditional_Before
    {
        public double DisabilityAmount(int seniority, int monthsDisabled, bool isPartTime)
        {
            // Quá nhiều if rời rạc cùng trả về 0
            if (seniority < 2) return 0;
            if (monthsDisabled > 12) return 0;
            if (isPartTime) return 0;

            return 5000;
        }
    }
}
