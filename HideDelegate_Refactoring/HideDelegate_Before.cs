using System;

namespace HideDelegate_Refactoring
{
    public class Department
    {
        public string Manager { get; set; } = "Mr. John";
    }

    public class Person_Before
    {
        public Department Department { get; set; } = new Department();
    }

    public class Client_Before
    {
        public void PrintManager()
        {
            var person = new Person_Before();
            // Client phải tự mò qua Department mới lấy được Manager (Bị lộ Delegate)
            string manager = person.Department.Manager;
            Console.WriteLine("Quản lý (Before): " + manager);
        }
    }
}