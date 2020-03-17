using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class Mather
    {

        public int addition(int num)
        {
            int newNum = num + 10;
            return newNum;
        }

        public decimal addition(decimal num)
        {
            decimal newNum = num * 2;
            return newNum;
        }

        public int addition(string num)
        {
            int convertNum = Convert.ToInt32(num);
            int newNum = convertNum - 1;
            return newNum;
        }


    }
}
