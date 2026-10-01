using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTypeCodeWithClass_Refactoring
{
    // C# hỗ trợ Enum cực tốt cho việc này
    public enum BloodGroup
    {
        O, A, B, AB
    }

    public class Person_After
    {
        // Sử dụng Enum thay vì số nguyên
        public BloodGroup BloodGroup { get; set; }
    }
}
