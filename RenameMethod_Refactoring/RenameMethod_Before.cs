using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenameMethod_Refactoring
{
    public class RenameMethod_Before
    {
        private string _fName = "Nguyễn";
        private string _lName = "Huế";

        // Tên hàm 'GetNm' quá vắn tắt, khó hiểu
        public string GetNm()
        {
            return _fName + " " + _lName;
        }
    }
}
