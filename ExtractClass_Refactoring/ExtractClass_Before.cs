using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractClass_Refactoring
{
    public class Person_Before
    {
        public string Name { get; set; } = "Alice";

        // Thuộc tính điện thoại không nên nằm lộn xộn trong Person
        public string OfficeAreaCode { get; set; } = "028";
        public string OfficeNumber { get; set; } = "38123456";

        public string GetTelephoneNumber()
        {
            return "(" + OfficeAreaCode + ") " + OfficeNumber;
        }
    }
}
