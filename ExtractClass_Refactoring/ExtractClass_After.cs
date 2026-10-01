using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractClass_Refactoring
{
    // Tách riêng thành một class độc lập
    public class TelephoneNumber
    {
        public string AreaCode { get; set; } = "028";
        public string Number { get; set; } = "38123456";

        public string GetTelephoneNumber()
        {
            return "(" + AreaCode + ") " + Number;
        }
    }

    public class Person_After
    {
        public string Name { get; set; } = "Alice";
        // Sử dụng class vừa tách
        public TelephoneNumber OfficeTelephone { get; set; } = new TelephoneNumber();
    }
}
