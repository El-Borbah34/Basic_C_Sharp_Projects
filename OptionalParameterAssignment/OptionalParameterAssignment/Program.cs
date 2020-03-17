using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameterAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Please give two numbers one at a time when prompted, please know that a second number is not need to run this program.");
            int userNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now what is that second number? (Just hit enter if you don't want to provide a second number.)");
            string secondNum = Console.ReadLine();
            int finishNum = string.IsNullOrEmpty(secondNum) ?
                calculator.adding(userNum) :
                calculator.adding(userNum, Convert.ToInt32(secondNum));
            Console.WriteLine("Your number(s) added eqauls: " + finishNum);

            Console.ReadLine();
        }
    }
}
