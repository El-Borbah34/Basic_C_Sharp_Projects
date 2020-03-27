using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give us a number. Any number.");
            int userNum = Convert.ToInt32(Console.ReadLine());

            using(StreamWriter file = new StreamWriter(@"C:\Users\Hal 9000\logs\log.txt", true))
            {
                file.WriteLine(userNum);
            }

            string text = File.ReadAllText(@"C:\Users\Hal 9000\logs\log.txt");
            Console.WriteLine(text);
            Console.ReadLine();


        }
    }
}
