using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a simple program
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " +total);
            //Console.ReadLine();

            //bool isStudying = false;
            //byte hoursWorked = 42;
            //sbyte currentTemp = -23;
            //char questionMark = '\u2103';

            //decimal moneyInBank = 100.5m;

            //double heightinCentimeters = 211.23243223;

            //float secondsLeft = 2.6f;

            //short temponMars = -341;

            //string myName = "Jesse";

            //int currentAge = 30;
            //string yearOld = currentAge.ToString();

            //bool isRaining = true;
            //string rainingStatus = Convert.ToString(isRaining);
            //Console.WriteLine(rainingStatus);
            //Console.ReadLine();

            List<int> numList = new List<int>() { 45, 77, 99, 100 };
            bool doesWork = false;

            while (!doesWork)
            {
                try
                {
                    Console.WriteLine("Give a number to divide by.");
                    int userNum = Convert.ToInt32(Console.ReadLine());

                    foreach (int num in numList)
                    {
                        int newNum = num / userNum;
                        Console.WriteLine(newNum);
                        doesWork = true;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    doesWork = false;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                    doesWork = false;
                }
                finally
                {
                    if(doesWork == true)
                    {
                        Console.WriteLine("That Worked!");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
