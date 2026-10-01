using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenameMethod_Refactoring
{
    public class RenameMethod_Real
    {
        // Thực tế: Thay vì đặt tên hàm là 'Proc()' khó hiểu, đổi thành 'KiemTraHetHanSuDung()'
        public bool KiemTraHetHanSuDung(DateTime ngayHetHan)
        {
            return DateTime.Now > ngayHetHan;
        }
    }
}
