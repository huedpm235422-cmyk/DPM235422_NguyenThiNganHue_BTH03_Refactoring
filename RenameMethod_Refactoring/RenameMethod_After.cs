using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenameMethod_Refactoring
{
    public class RenameMethod_After
    {
        private string _firstName = "Nguyễn";
        private string _lastName = "Huế";

        // Đổi tên thành 'GetFullName' rõ ràng và chuẩn quy ước
        public string GetFullName()
        {
            return _firstName + " " + _lastName;
        }
    }
}
