using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly rate at your place of work?");
            int person1rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Also how many hours do you work per week Person 1?");
            int person1hours = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate at your place of work?");
            int person2rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours do your work per week Person 2?");
            int person2hours = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            int salaryPerson1 = person1hours * person1rate * 52;
            Console.WriteLine("The Annual salary of Person 1 is " + salaryPerson1);
            Console.ReadLine();

            int salaryPerson2 = person2hours * person2rate * 52;
            Console.WriteLine("The Annual salary of Person 2 is " +salaryPerson2);
            Console.ReadLine();

            bool largerWage = salaryPerson1 > salaryPerson2;
            Console.WriteLine("Does Person 1 mke more money than Person 2? " +largerWage);
            Console.ReadLine();


        }
    }
}
