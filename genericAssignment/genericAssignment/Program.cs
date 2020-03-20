using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<int> employeesNum = new Employee<int>();
            Employee<string> employees = new Employee<string>();
            employees.things = new List<string>() { "Pierson", "Jakey", "Fy", "Jason" };

            foreach (string employee in employees.things)
            {
                Console.WriteLine(employee);
            }
            Console.ReadLine();

            employeesNum.things = new List<int>() { 6, 34, 17, 31 };

            foreach (int employee in employeesNum.things)
            {
                Console.WriteLine(employee);
            }
            Console.ReadLine();

            // HEY was I suppose to put these Loops into ONE loop or is it fine the way I did it??
        }
    }
}
