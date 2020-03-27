using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDate = new DateTime();
            currentDate = DateTime.Now;


            Console.WriteLine(currentDate);
            
            Console.WriteLine("\n\nGive a random number, please.");
            int userNum = Convert.ToInt32(Console.ReadLine());

            DateTime hoursAddedDate = currentDate.AddHours(userNum);

            Console.WriteLine("The date is currently {0}. But with our Users added hours, the date and time is currently {1}!", currentDate, hoursAddedDate);
            Console.ReadLine();
        }
    }
}
