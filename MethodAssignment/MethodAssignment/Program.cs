using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a whole number and we will use it in some math functions.");
            int userNum = Convert.ToInt32(Console.ReadLine());

            int addAnswer = Mather.Add1(userNum);
            Console.WriteLine("\n" + addAnswer + " is the new number for our first function, which added to your current number");

            int subAnswer = Mather.Subtract(userNum);
            Console.WriteLine("\n" +subAnswer + ": is our second vaule that was substracted by 2.");

            int multiAnswer = Mather.Multiply(userNum);
            Console.WriteLine("\n" + multiAnswer + ": is the final answer. We got this by multiplying by 100");

            // oobject impl
            // Mather mather = new Mather();

            // mather.Add(shit);



            // static implementation
            // Mather.Add(shit);

            Console.ReadLine();
        }
    }
}
