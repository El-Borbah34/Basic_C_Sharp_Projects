using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameterAssignment
{
    public class Calculator
    {
        public int adding(int num, int num2 = 0)
        {
            int newNum = num + 5 + num2;
            return newNum;
        }
    }
}
