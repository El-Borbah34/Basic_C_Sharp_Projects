using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            Console.WriteLine("What is a good first name?");
            employee.firstName = Console.ReadLine();
            Console.WriteLine("Now choose a last name.");
            employee.lastName = Console.ReadLine();

            employee.SayName();

            Console.WriteLine("I didn't use \"Sample\" \"Student\" because I wanted to actully use it." );
            Console.ReadLine();
        }
    }
}
