using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlineClass_Refactoring
{
    public class TelephoneNumber
    {
        public string AreaCode { get; set; } = "028";
        public string Number { get; set; } = "38123456";
        public string GetTelephoneNumber() => $"({AreaCode}) {Number}";
    }

    public class Person_Before
    {
        public string Name { get; set; } = "Ngân Huế";
        // Lớp TelephoneNumber không làm gì nhiều, gây cồng kềnh
        public TelephoneNumber OfficeTelephone { get; set; } = new TelephoneNumber();
    }
}
