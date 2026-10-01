using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTypeCodeWithClass_Refactoring
{
    public class Person_Before
    {
        // Dùng số nguyên làm loại nhóm máu (rất dễ gán sai, vd: = 99)
        public const int O = 0;
        public const int A = 1;
        public const int B = 2;
        public const int AB = 3;

        public int BloodGroup { get; set; }
    }
}
