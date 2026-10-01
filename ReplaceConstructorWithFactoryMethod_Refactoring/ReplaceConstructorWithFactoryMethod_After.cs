using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceConstructorWithFactoryMethod_Refactoring
{
    public class Employee_After
    {
        public int Type { get; private set; }

        private Employee_After(int type)
        {
            Type = type;
        }

        // Factory Method rõ ràng
        public static Employee_After Create(int type)
        {
            return new Employee_After(type);
        }
    }
}
