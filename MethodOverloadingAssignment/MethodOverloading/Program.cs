using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Mather mather = new Mather();

            Console.WriteLine("Type in a whole number, we will use it in some math problems.");
            int userNum = Convert.ToInt32(Console.ReadLine());
            int firstAnswer = mather.addition(userNum);
            Console.WriteLine("The first answer is: " + firstAnswer);

            Console.WriteLine("This time give us a decimal number.");
            decimal userNum2 = Convert.ToDecimal(Console.ReadLine());
            decimal secondAnswer = mather.addition(userNum2);
            Console.WriteLine(secondAnswer + ": is your number times 2.");

            Console.WriteLine("Write a last number and will do a final operation on it.");
            string userNum3 = Console.ReadLine();
            int thirdAnswer = mather.addition(userNum3);
            Console.WriteLine(thirdAnswer + ": is your final number.");

            Console.ReadLine();



        }
    }
}
