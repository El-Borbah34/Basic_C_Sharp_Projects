using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace WeekdayAssigment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool correctDay = false;
            // this sets up a text processor in the English-US format (or whatever the user chose)
            TextInfo textProcessor = new CultureInfo("en-US", true).TextInfo;
            //var actualDay = DaysOfWeek.Monday.ToString().ToLower();

            // DateTime.Today is a standard Windows.NET library function that lets you get the date and time from your operating system
            DaysOfWeek today = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), DateTime.Today.DayOfWeek.ToString());

            Console.WriteLine("Enter what day it is today.");
            while (!correctDay)
            {
                try
                {
                    string userInput = Console.ReadLine();

                    // we don't want them to use integers, BUT it won't return an error
                    // so we need a custom statement to handle that and let them know
                    // they need to not use just a number value
                    if (int.TryParse(userInput, out int tempInt))
                    {
                        Console.WriteLine("Please enter a day of the week, not a number.");
                    }
                    // we need this to happen if they use anything that translates to a string
                    // i.e. 2butt
                    // i.e. monday
                    else
                    {
                        // use a special function of a TextInfo text processor object to make the text a specific capitalization style
                        string capitalizedInput = textProcessor.ToTitleCase(userInput);

                        DaysOfWeek userGuess = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), capitalizedInput);

                        if (userGuess == today)
                        {
                            Console.WriteLine("That is the correct day.");
                            correctDay = true;
                        }
                        // I added this so the user knew if they entered the wrong thing instead of just cycling back to the top with no message
                        else
                        {
                            Console.WriteLine("You entered the incorrect day; guess again!");
                        }
                    }

                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Please enter a day of the week.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("I don't know what you did, but here you are.");
                }
            }
            Console.ReadLine();
        }

        public enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }   
}