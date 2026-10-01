using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceNestedConditionalWithGuardClauses_Refactoring
{
    public class ReplaceNestedConditionalWithGuardClauses_Before
    {
        public double GetPayAmount(bool isDead, bool isSeparated, bool isRetired)
        {
            double result;
            // if-else lồng nhau rất rối mắt
            if (isDead)
            {
                result = DeadAmount();
            }
            else
            {
                if (isSeparated)
                {
                    result = SeparatedAmount();
                }
                else
                {
                    if (isRetired)
                    {
                        result = RetiredAmount();
                    }
                    else
                    {
                        result = NormalPayAmount();
                    }
                }
            }
            return result;
        }

        private double DeadAmount() => 0;
        private double SeparatedAmount() => 50;
        private double RetiredAmount() => 100;
        private double NormalPayAmount() => 200;
    }
}
