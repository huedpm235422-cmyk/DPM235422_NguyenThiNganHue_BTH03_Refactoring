using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceConstructorWithFactoryMethod_Refactoring
{
    public class Employee_Before
    {
        public int Type { get; set; }

        // Constructor phải xử lý logic loại nhân viên
        public Employee_Before(int type)
        {
            Type = type;
        }
    }
}
