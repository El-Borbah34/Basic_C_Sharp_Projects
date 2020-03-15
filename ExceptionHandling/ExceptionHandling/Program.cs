using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> NumbersToDivide = new List<int>() { 6, 14, 60, 100 };
            Console.WriteLine();
            
            try
            {
                Console.WriteLine("Write a number to divide our list by.");
                int userNum = Convert.ToInt32(Console.ReadLine());
                foreach (int number in NumbersToDivide)
                {
                    int dividedNumber = number / userNum;
                    Console.WriteLine(dividedNumber);
                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            Console.WriteLine("The try/catch block has ended.");
            Console.ReadLine();
          


            //try
            //{
            //    Console.WriteLine("Pick a number.");
            //    int numberOne = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Pick a second number.");
            //    int numberTwo = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Dividing the two..");
            //    int numberThree = numberOne / numberTwo;
            //    Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
            //    Console.ReadLine();
            //}
            //catch(FormatException ex)
            //{
            //    Console.WriteLine("Please use a whole number."); //can write anything we want inside WriteLine()  
            //    return;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Please don't use a Zero.");
            //}
            //catch(Exception ex) // the use of just Exception is a general use of the term. In these cases we would want to use WriteLine(What we want to tell the user.)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.ReadLine();
            //}
            //Console.ReadLine();
        }
    }
}
