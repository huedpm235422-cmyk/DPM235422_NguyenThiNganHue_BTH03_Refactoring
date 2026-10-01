using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlineClass_Refactoring
{
    public class Person_After
    {
        public string Name { get; set; } = "Ngân Huế";

        // Inline (gộp) trực tiếp các thuộc tính của TelephoneNumber vào đây
        public string AreaCode { get; set; } = "028";
        public string Number { get; set; } = "38123456";

        public string GetTelephoneNumber() => $"({AreaCode}) {Number}";
    }
}
