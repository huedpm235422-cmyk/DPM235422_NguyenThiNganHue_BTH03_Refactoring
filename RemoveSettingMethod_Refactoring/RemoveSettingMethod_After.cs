using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveSettingMethod_Refactoring
{
    public class Account_After
    {
        // Khóa lại bằng readonly, chỉ gán 1 lần trong Constructor
        private readonly string _id;

        public Account_After(string id)
        {
            _id = id;
        }

        // Không còn hàm SetId() nữa
        public string GetId() => _id;
    }
}
