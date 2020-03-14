using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        //int[] testScores = { 99, 98, 85, 70, 82, 34, 91, 90, 94 };

        //for (int i = 0; i < testScores.Length; i++)
        //{
        //    if (testScores[i] > 85)
        //    {
        //        Console.WriteLine("Passing Test Scores: " +testScores[i]);
        //    }
        //}
        //Console.ReadLine();

        //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

        //for (int j = 0; j < names.Length; j++)
        //{
        //    Console.WriteLine(names[j]);

        //    if (names[j] == "Jesse")
        //    {
        //        //Console.WriteLine(names[j]);
        //    }
        //}
        //Console.ReadLine();

        //List<int> testscores = new List<int>();
        //testscores.Add(98);
        //testscores.Add(99);
        //testscores.Add(81);
        //testscores.Add(72);
        //testscores.Add(70);

        //foreach (int score in testscores)
        //{
        //    if (score > 85)
        //    {
        //        Console.WriteLine("Passing test score: " + score);
        //    }
        //}
        //Console.ReadLine();

        //List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

        //foreach (string name in names)
        //{
        //    if (name == "Jesse")
        //    {
        //        Console.WriteLine(name);
        //    }
        //}
        //Console.ReadLine();

        //List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
        //List<int> passingScores = new List<int>();

        //foreach (int score in testScores)
        //{
        //    if (score > 85)
        //    {
        //        passingScores.Add(score);
        //    }
        //}
        //Console.WriteLine(passingScores.Count);
        //Console.ReadLine();


        /*===========================Assignment========================================*/
        string[] people = { "pierson", "fy", "jake", "jason" };
        Console.WriteLine("starting with \"likes to\" write out an action or verb.");
        string verb = Console.ReadLine();

        for (int i = 0; i < people.Length; i++)
        {
            Console.WriteLine(people[i] + ' ' + verb);
        }
        Console.ReadLine();

        /*=========================== Infinite Loop; < and <= Comparisons ==============================*/
        int[] gradeScores = { 89, 99, 67, 41, 76, 78, 50 };

        for (int i = 0; i < gradeScores.Length; i++) // ****I made the i = 0 and it became an infinte loop!*******
        {
            if (gradeScores[i] <= 60) // used the same code and inserted < instead of <=
            {
                Console.WriteLine("The failing grades are: " + gradeScores[i]);
            }
        }
        Console.ReadLine();
        /*===========================Assignment 6, 7 , and 8 List============================*/
        bool foundAFruit = false;
        List<string> fruitList = new List<string>() { "oranges", "grapes", "apples", "watermelon", "mango" };

        while (foundAFruit == false) // loops until WE DECLARE that we've found a fruit
        {
            Console.WriteLine("Name a random fruit and see if its in my list!");
            string userFruit = Console.ReadLine().ToLower();
            foreach (string fruit in fruitList)
            {
                if (userFruit == fruit)
                {
                    Console.WriteLine("You found a fruit in the list with an index of: " + fruitList.IndexOf(fruit));
                    foundAFruit = true;
                    break;
                }
            }
            if (foundAFruit == false)
            {
                Console.WriteLine("That fruit was not in the list.");
            }
        }
        Console.ReadLine();


        /*===============================Assignment 9-10=======================================*/
        bool rightColor = false;
        List<string> colorsofRainbow = new List<string>() { "red", "blue", "orange", "yellow", "purple", "blue" };

        while (!rightColor) //need to prove this to be true in order to stop my loop
        {
            Console.WriteLine("Pick your favorite color of the rainbow!");
            string userColor = Console.ReadLine().ToLower();

            for (int i = 0; i < colorsofRainbow.Count; i++) //need to loop for each index in the list
            {
                if (userColor == colorsofRainbow[i])
                {
                    Console.WriteLine("Huzzah!  Your color has an index of: " + i + " and its a great color....loser.");
                    rightColor = true;  //once color is found, need to display that the color is valid and I need a way to stop my loop through the boolean I made.
                }
            }

            if (rightColor == false)
            {
                Console.WriteLine("That color is not in this rainbow, please pick again.");  //also need to make an error message for wrong inputs, that will also send the user back to the while loop
            }


        }
        Console.ReadLine();

        /*======================================Assignment 11==================================*/
        List<string> namesOfFriends = new List<string>() { "pierson", "fy", "ben", "jason", "fy", "adam", "pierson" };

        List<string> namesAlreadySeen = new List<string>();

        foreach (string name in namesOfFriends)
        {
            Console.WriteLine(name); // print name to user
            if (namesAlreadySeen.Contains(name)) // if the list of names we've already seen Contains the current name
            {
                Console.WriteLine("We have seen this!"); // print 'we've already seen this'
            }
            else //else
            {
                namesAlreadySeen.Add(name); // Add name to the list of names we've already seen
            }
        }
        Console.ReadLine();

        //for(int i = 0; i < namesofFriends.Count; i++)
        //{
        //    string name = namesofFriends[i];
        //    Console.WriteLine(name);
        //    if(namesofFriends.IndexOf(name) != i)
        //    {
        //        Console.WriteLine("We have seen this name before.");
        //    }
        //}
    }
}

