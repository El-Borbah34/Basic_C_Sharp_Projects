using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodwithnoparameters
{
    public class Calculator
    {
        public void getValue(int inputNumber, out int outputNumber)
        {
            outputNumber = inputNumber / 2;
        }

        public void getValue(int userInput, out int outputNumber, out int outputNumber2)
        {
            outputNumber = userInput + 100;
            outputNumber2 = outputNumber + userInput;
        }
    }
    public static class Abacus
    {
        public static int adder(int num, int num2)
        {
            int combined = num + num2;
            return combined;
        }
    }
}
