using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceNestedConditionalWithGuardClauses_Refactoring
{
    public class ReplaceNestedConditionalWithGuardClauses_After
    {
        public double GetPayAmount(bool isDead, bool isSeparated, bool isRetired)
        {
            // Dùng Guard Clauses: Thoát hàm sớm nếu gặp trường hợp đặc biệt
            if (isDead) return DeadAmount();
            if (isSeparated) return SeparatedAmount();
            if (isRetired) return RetiredAmount();

            // Luồng code chính (bình thường) nằm ở cuối, không bị thụt lề
            return NormalPayAmount();
        }

        private double DeadAmount() => 0;
        private double SeparatedAmount() => 50;
        private double RetiredAmount() => 100;
        private double NormalPayAmount() => 200;
    }
}
