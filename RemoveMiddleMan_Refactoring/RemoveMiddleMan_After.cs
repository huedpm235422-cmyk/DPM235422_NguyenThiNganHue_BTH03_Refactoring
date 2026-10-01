using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveMiddleMan_Refactoring
{
    public class Person_After
    {
        private Department _department = new Department();

        // Bỏ các hàm trung gian, cung cấp luôn Department cho Client tự gọi
        public Department GetDepartment()
        {
            return _department;
        }
    }
}
