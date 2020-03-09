using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " +difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine("Ten times five = " +product.ToString());
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine("One-Hundred divided by five = " +quotient.ToString());
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();\

            //bool trueOrfalse = 12 < 5;
            //Console.WriteLine(trueOrfalse.ToString());
            //Console.ReadLine();

            //int roomTemperature = 70;
            //int currentTemperature = 70;

            //bool isWarm = currentTemperature >= roomTemperature;
            //bool isWarm = currentTemperature != roomTemperature;
            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            Console.WriteLine("Type in any Whole Number. We will multiply it by 50!");
            int multiply = Convert.ToInt32(Console.ReadLine());
            int multiplyTotal = multiply * 50;
            Console.WriteLine("Your number times 50 = " + multiplyTotal);
            Console.ReadLine();

            Console.WriteLine("Type in any whole number and we will add 25 to it!");
            int addition = Convert.ToInt32(Console.ReadLine());
            int additionTotal = addition + 25;
            Console.WriteLine("Your number plus 25 = " +additionTotal);
            Console.ReadLine();

            Console.WriteLine("Type in any whole number and it will be divided by 12.5");
            int divided = Convert.ToInt32(Console.ReadLine());
            double dividedTotal = divided / 12.5;
            Console.WriteLine("Your total is " + dividedTotal);
            Console.ReadLine();

            Console.WriteLine("Type in any whole number and we will see if its greater than my number!");
            int greaterthanorLessthan = Convert.ToInt32(Console.ReadLine());
            bool greaterthan = greaterthanorLessthan >= 50;
            Console.WriteLine("Is your number greater than my number.... " + greaterthan);
            Console.ReadLine();

            Console.WriteLine("Type in any whole number and we will divide it by 7 to get a remainder");
            int userNum = Convert.ToInt32(Console.ReadLine());
            int remainder = userNum % 7;
            Console.WriteLine("The remainder of your number divided by seven is " + remainder + "!");
            Console.ReadLine();
            



        }
    }
}
