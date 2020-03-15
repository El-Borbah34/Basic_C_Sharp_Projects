using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the weight of your package, Please use a whole number: ");
            int weight = Convert.ToInt32(Console.ReadLine());                                                                   //ask if for 
            Console.WriteLine("Please enter the package width in whole numbers.");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package height in whole numbers.");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package length in whole numbers.");
            int length = Convert.ToInt32(Console.ReadLine());

            if (width >= 50 || height >= 50 || length >= 50 || weight >= 50)
            {
                Console.WriteLine("Package is too fatty to be shipped, doggy.");    //ask Fy to help insert a return, to get correct data, and then continue program
            }
            else
            {
                decimal quote = (width * height * length * weight) / 100;

                Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
            }
            Console.ReadLine();




            //Console.WriteLine("What is your favorite number doggie?");
            //int favNum = Convert.ToInt32(Console.ReadLine());

            //string result = favNum == 12 ? "You have an awesome favorite number." : "You don't have an awesome favorite number.";
            //Console.WriteLine(result);
            //Console.ReadLine();


            //int roomTemperature = 70;

            //Console.WriteLine("Hi, What is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("It is colder than room temperature");
            //}
            //else
            //{
            //    Console.WriteLine("Something went wrong");
            //}





            //int currentTemperature = 77;
            //int roomTemperature = 70;

            //string comparisonResult = currentTemperature == roomTemperature ? "It is room Temperature." : "It is not room Temperature.";

            //Console.WriteLine(comparisonResult);

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("Room is warmer than the current temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("It is not exactly room temperature.");
            //}
            //Console.ReadLine(); 
        }
    }
}
