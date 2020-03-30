using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validAnswer = false;
            while (!validAnswer)
            {
                Console.WriteLine("What age are you?");
                try
                {
                    int userAge = Convert.ToInt32(Console.ReadLine());
                    int userBirthYear = DateTime.Now.Year - userAge;

                    if (userAge < 0)
                    {
                        throw new NegativeException();
                    }
                    else if (userAge == 0)
                    {
                        throw new ZeroException();
                    }
                    else
                    {
                        Console.WriteLine("Your birth year is {0}", userBirthYear);
                        validAnswer = true;
                    } 
                }
                catch(FormatException)
                {
                    Console.WriteLine("Please use digit numbers only.");
                }
                catch(NegativeException)
                {
                    Console.WriteLine("Please don't use negative numbers!");
                }
                catch (ZeroException)
                {
                    Console.WriteLine("You are not zero years old, hahaha!");
                }
                catch (Exception)
                {
                    Console.WriteLine("Not really sure what you did here...go tell Rick.");
                    return;
                }
                finally
                {
                    if(validAnswer == true)
                    {
                        Console.ReadLine();
                    }
                }
            }

        }
    }
}
