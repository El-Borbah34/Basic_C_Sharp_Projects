using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractAssignment
{
    public class Employee : Person, IQuittable // New coode for Assignment on pg. 179
    {
        public int id { get; set; }

        public override void SayName()
        {
            base.SayName();
        }
        public void Quit() //New coode for Assignment on pg. 179
        {
            Console.WriteLine("This is ending of project.");
            Console.ReadLine();
        }

        public static bool operator == (Employee employee, Employee employee1)
        { 
            if (employee.id == employee1.id)
            {
                Console.WriteLine("There are two people with the same ID.");
                return true;
            }
            else
            {
                Console.WriteLine("Perfect, nobody has your employee ID");
                return false;
            }
        }

        public static bool operator != (Employee employee, Employee employee1)
        {
            if (employee.id != employee1.id)
            {
                Console.WriteLine("Perfect, nobody has your employee ID");
                return false;
            }
            else
            {
                Console.WriteLine("There are two people with the same ID.");
                return true;
            }
        }
    }
}
