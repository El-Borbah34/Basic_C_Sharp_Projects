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
            Employee employee1 = new Employee();
            IQuittable quittable = new Employee(); // New coode for Assignment on pg. 179 also not sure but I think I might be doing this wrong.

            employee.firstName = "Pierson";
            employee1.firstName = "John";
            employee.id = 123;
            employee1.id = 123;

            Console.WriteLine(employee == employee1);
            Console.ReadLine();


            //Console.WriteLine("What is a good first name?");
            //employee.firstName = Console.ReadLine();
            //Console.WriteLine("Now choose a last name.");
            //employee.lastName = Console.ReadLine();

            //employee.SayName();

            //Console.WriteLine("I didn't use \"Sample\" \"Student\" because I wanted to actully use it." );
            //Console.ReadLine();

            //quittable.Quit(); //New coode for Assignment on pg. 179

        }
    }
}
