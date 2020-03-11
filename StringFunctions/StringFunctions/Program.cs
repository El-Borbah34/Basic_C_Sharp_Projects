using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {

            string num1 = "I like to run";
            string num2 = " I like to jog";
            string num3 = " I like to sprint";

            Console.WriteLine(num1 + num2 + num3);
            Console.ReadLine();
            Console.WriteLine(num1.ToUpper());
            Console.ReadLine();

            StringBuilder paragraph = new StringBuilder();
            paragraph.Append("I need more time to study.");
            paragraph.Append(" I am very close to understanding While Loops.");
            paragraph.Append(" I am also starting to understand Do While Loops.");
            paragraph.Append(" I am also starting to understand how to combine multiple loops.");
            paragraph.Append(" But yet it is still so very confusing to me still.");
            Console.WriteLine(paragraph);
            Console.ReadLine();



            //StringBuilder sb = new StringBuilder();

            //sb.Append("My name is Jesse");
            //sb.Append(" and I love to fart.");


            //Console.WriteLine(sb);
            //Console.ReadLine();



            //string name = "Jesse";
            //string quote = "The Man said, \"Hello\", Jesse. \n Hello On a new line. \n \t Hello on a new Tab.";
            //string fileName = @"C:\\Users\\Jesse";

            //bool trueOrfalse = name.Contains("s");
            //trueOrfalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToUpper();
            //name = name.ToLower();


            //Console.WriteLine(trueOrfalse);
            //Console.ReadLine();
        }
    }
}
