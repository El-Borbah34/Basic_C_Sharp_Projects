using System;
using System.Collections.Generic;


    class Program
    {
        static void Main()
        {
        /*==================String Array==============================================*/

            string[] stringArray = { "Pierson", "Fy", "Jason", "John" };

            Console.WriteLine("Please choose a number from 1 to 10");
            int userString = Convert.ToInt32(Console.ReadLine());

            if (userString > 3)
            {
                Console.WriteLine("That Array does not exist, please choose another number");
                userString = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("You chose: " + stringArray[userString]);
            Console.ReadLine();

        /*============================Integer Array ===========================*/

            int[] integerArray = { 34, 13, 56, 11, 77, 89, 12 };

            Console.WriteLine("Choose another number from 1 to 10");
            int userInteger = Convert.ToInt32(Console.ReadLine());

            if (userInteger > 6)
            {
                Console.WriteLine("That number in the index doesn\'t exist, please choose another.");
                userInteger = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("You chose: " + integerArray[userInteger]);
            Console.ReadLine();

        /*==========================List====================================*/

            List<string> stringList = new List<string>();
            stringList.Add("Jake");
            stringList.Add("Tom");
            stringList.Add("Anne");
            stringList.Add("Philip");
            stringList.Add("Kaylin");

            Console.WriteLine("Hello, once again! \n Please choose another number from 1 to 10");
            int listofFamily = Convert.ToInt32(Console.ReadLine());

            if (listofFamily > 4)
            {
                Console.WriteLine("That is an invalid number, please choose again!");
                listofFamily = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("You chose: " + stringList[listofFamily] + " as the coolest memeber of the family.");
            Console.ReadLine();
        
        
        
        
            //List<string> intList = new List<string>(); //changed <int> to string, you can use the other data types.

            //intList.Add("Hello");
            //intList.Add("Jesse");
            //intList.Remove("Jesse");


            //Console.WriteLine(intList[0]);
            //Console.ReadLine();

        
            //int[] numArray = new int[5];
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[3] = 200;
            //numArray[4] = 5000;
            
            ////this new line of code is the same as the one above. it is just easier to do this. 
            //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

            ////This is the easiest way to assign an array. visual studios knows how to auto complete this.
            //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

            //numArray2[5] = 650;

            //Console.WriteLine(numArray2[5]);
            //Console.ReadLine();
        }
    }

