using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Write out a whole number.");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now write out a second number.");
            int userNum2 = Convert.ToInt32(Console.ReadLine());

            calculator.divide(num1: userNum1, num2: userNum2);
            Console.ReadLine();
        }
    }
}
