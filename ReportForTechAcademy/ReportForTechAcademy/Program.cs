using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportForTechAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Custom Function Declarations

            /// makes sure a string of user input is either "true" or "false"
            /// only returns the string once "true" or "false"
            string CheckForBoolean(string inputToCheck)
            {
                inputToCheck = inputToCheck.ToLower();

                while (inputToCheck != "true" && inputToCheck != "false")
                // if input is not valid, i.e not equal to true / false
                {
                    // get new input
                    Console.WriteLine("Please enter either true or false.");
                    inputToCheck = Console.ReadLine().ToLower();
                }

                // this will only happen if input is valid, so technically it operates as 'else'
                return inputToCheck;
            }


            ///////////////////////////////////////////////////////////////////////////
            // start of Main() program

            Console.WriteLine("The Tech Academy");
            Console.ReadLine();
            Console.WriteLine("Student Daily Report.");
            Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();

            Console.WriteLine("What page number are you on?");
            string pageNumber = Console.ReadLine();
            int pgNum = Convert.ToInt32(pageNumber);

            Console.WriteLine("Do you need help with anything? Please answer with, 'true' or 'false'");
            string help = CheckForBoolean(Console.ReadLine());
            bool helpneeded = Convert.ToBoolean(help);

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string experiences = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string studytime = Console.ReadLine();
            double hoursStudy = Convert.ToDouble(studytime);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            Console.ReadLine();
        }
    }
}
