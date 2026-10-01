using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractMethod_Refactoring
{
    public class ExtractMethod_Before
    {
        public void PrintOwing(string name, double amount)
        {
            // In ra banner (Tiêu đề)
            Console.WriteLine("*****************************");
            Console.WriteLine("****** Customer Owes ********");
            Console.WriteLine("*****************************");

            // In ra chi tiết
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Amount: " + amount);
        }
    }
}
