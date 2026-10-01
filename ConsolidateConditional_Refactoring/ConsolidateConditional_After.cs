using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolidateConditional_Refactoring
{
    public class ConsolidateConditional_After
    {
        public double DisabilityAmount(int seniority, int monthsDisabled, bool isPartTime)
        {
            // Gom lại và tách thành 1 hàm kiểm tra chung
            if (IsNotEligibleForDisability(seniority, monthsDisabled, isPartTime))
                return 0;

            return 5000;
        }

        private bool IsNotEligibleForDisability(int seniority, int monthsDisabled, bool isPartTime)
        {
            return (seniority < 2) || (monthsDisabled > 12) || isPartTime;
        }
    }
}
