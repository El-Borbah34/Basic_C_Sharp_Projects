using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = string.Empty;
            bool correctName = false;

            do
            {
                Console.WriteLine("What is my name?");
                myName = Console.ReadLine().ToLower();

                if (myName == "pierson")
                {
                    Console.WriteLine("Yes, {0} is my name.", myName);
                    correctName = true;
                }

            } while (correctName == false);
            Console.ReadLine();




            Console.WriteLine("Write True or false.");
            bool trueorFalse = Convert.ToBoolean(Console.ReadLine().ToLower());

            while (!trueorFalse)
            {
                Console.WriteLine("Try the other option");
                trueorFalse = Convert.ToBoolean(Console.ReadLine().ToLower());
            }

            Console.WriteLine("It was hard for me to make this a boolean While Statement, so in other words, if you typed in false the while loop would never run");
            Console.ReadLine();










            //Console.WriteLine("Guess a Number?");
            //int number = Convert.ToInt32(Console.ReadLine());
            //bool isGuessed = number == 12;

            //do
            //{
            //    switch (number)
            //    {
            //        case 62:
            //            Console.WriteLine("You guessed 62. Try again.");
            //            Console.WriteLine("Guess a Number?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 29:
            //            Console.WriteLine("You guessed 29. Try again.");
            //            Console.WriteLine("Guess a Number?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 55:
            //            Console.WriteLine("You guessed 55. Try again.");
            //            Console.WriteLine("Guess a Number?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 12:
            //            Console.WriteLine("You guessed 12. That is correct!");
            //            isGuessed = true;
            //            break;
            //        default:
            //            Console.WriteLine("You are wrong.");
            //            Console.WriteLine("Guess a Number?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //    }
            //}
            //while (!isGuessed);

            //Console.Read();
        }
    }
}
