using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractMethod_Refactoring
{
    public class ExtractMethod_After
    {
        public void PrintOwing(string name, double amount)
        {
            PrintBanner();
            PrintDetails(name, amount);
        }

        private void PrintBanner()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("****** Customer Owes ********");
            Console.WriteLine("*****************************");
        }

        private void PrintDetails(string name, double amount)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Amount: " + amount);
        }
    }
}
