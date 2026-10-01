using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveMiddleMan_Refactoring
{
    public class Department
    {
        public string GetManager() => "Mr. John";
        public string GetName() => "IT";
    }

    public class Person_Before
    {
        private Department _department = new Department();

        // Person trở thành "kẻ trung gian" chỉ để truyền lệnh
        public string GetManager() => _department.GetManager();
        public string GetDepartmentName() => _department.GetName();
    }
}
