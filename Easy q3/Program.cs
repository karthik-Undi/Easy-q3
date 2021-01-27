using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_q1
{
    class Program
    {
        static void Main(string[] args)
        {

            var Employees = new List<string>();
            Console.WriteLine("Please enter the employee names in the order of their eligibility for promotion(Please enter blank to stop)");
            for (; ; )
            {
                String s = Console.ReadLine();
                if (s == "") break;
                else Employees.Add(s);
            }

            Console.WriteLine("The current size of the collection is " + Employees.Capacity);
            Employees.TrimExcess();
            Console.WriteLine("The size after removing the extra space is " + Employees.Capacity);
            Console.ReadKey();
        }
    }
}
