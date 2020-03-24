using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();

            numbers.Amount = 34.34M;
            decimal actualAmount = numbers.Amount; //did this just cause.

            Console.WriteLine(actualAmount);
            Console.ReadLine();
        }
    }
}
