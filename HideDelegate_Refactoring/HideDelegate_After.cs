using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideDelegate_Refactoring
{
    // Class Department vẫn giữ nguyên
    public class Department_After
    {
        public string Manager { get; set; } = "Mr. John";
    }

    public class Person_After
    {
        private Department_After _department = new Department_After();

        // Tạo hàm ủy quyền để giấu sự tồn tại của Department
        public string GetManager()
        {
            return _department.Manager;
        }
    }

    public class Client_After
    {
        public void PrintManager()
        {
            var person = new Person_After();
            // Client chỉ cần hỏi trực tiếp Person
            string manager = person.GetManager();
            Console.WriteLine("Quản lý (After): " + manager);
        }
    }
}
