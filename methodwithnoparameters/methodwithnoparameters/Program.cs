using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodwithnoparameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Give a number and we will return it divided by 2.");
            int userNum = Convert.ToInt32(Console.ReadLine());
            int y;

            calculator.getValue(userNum, out y);
            Console.WriteLine(y);
            Console.ReadLine();

            int random;
            int random2;
            calculator.getValue(userNum, out random, out random2);
            Console.WriteLine(random);
            Console.WriteLine(random2);
            Console.ReadLine();

            Calculator Abacus = new Calculator();

        }

        
    }
}
