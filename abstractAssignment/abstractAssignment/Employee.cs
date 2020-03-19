using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractAssignment
{
    public class Employee : Person, IQuittable // New coode for Assignment on pg. 179
    {
        public override void SayName()
        {
            base.SayName();
        }
        public void Quit() //New coode for Assignment on pg. 179
        {
            Console.WriteLine("This is ending of project.");
            Console.ReadLine();
        }



    }
}
