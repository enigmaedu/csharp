﻿using System;
using System.Linq;

namespace BasicConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello Again!!!");
            //Single line comment
            Console.Write("Hello World. ");
            Console.Write("Hello Again!!!");
            Console.WriteLine("Hello Again!!!");
            /*
             Multi line comment
             */
            string name = "John";
            Console.WriteLine(name);
            int myNum = 15;
            Console.WriteLine(myNum);
            const int myNumConst = 20;
            Console.WriteLine(myNumConst);
            double myDoubleNum = 5.99D;
            char myLetter = 'D';
            bool myBool = true;
            Console.WriteLine("Variable assignment test --> " + myDoubleNum + " " + myLetter + " " + myBool);
            int x = 5, y = 6, z = 50;
            Console.WriteLine(x + y + z); //addition
            int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double
            //converting a smaller type to a larger type size
            double myDouble1 = 9.78;
            int myInt1 = (int)myDouble1;    // Manual casting: double to int
            //converting a larger type to a smaller size type
            // Type your username and press enter
            Console.WriteLine("Enter username:");
            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();
            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Username is: " + userName);
            //Type conversion using convert method
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);
            Math.Max(5, 10);
            Math.Min(5, 10);
            Math.Sqrt(64);
            Math.Abs(-4.7);
            Math.Round(9.99);
            string txt = "Hello World";
            Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(txt.ToLower());   // Outputs "hello world"
            string firstName = "John ";
            string lastName = "Doe";
            string name1 = firstName + lastName;
            Console.WriteLine(name1);
            string name2 = string.Concat(firstName, lastName);
            Console.WriteLine(name2);
            /*Another option of string concatenation, is string interpolation,
                which substitutes values of variables into placeholders in a string.
            */
            string name3 = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name3);
            //Access Strings
            string myString = "Hello";
            Console.WriteLine(myString[0]); // Outputs "H"
            //Find the index position of a specific character
            Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"
            //Special Characters
            //string txt = "We are the so-called "Vikings" from the north."; //Incorrect
            string txt1 = "We are the so-called \"Vikings\" from the north.";
            //Boolean Expression
            int x1 = 10;
            int y1 = 9;
            Console.WriteLine(x1 > y1); // returns True, because 10 is higher than 9
            int x2 = 10;
            Console.WriteLine(x2 == 10); // returns True, because the value of x is equal to 10
            if (20 > 18)
            {
                Console.WriteLine("20 is greater than 18");
            }

            int time = 20;
            if (time < 18)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }

            //Short Hand If...Else (Ternary Operator)
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);

            //C# Switch
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("None");
                    break;
            }
            // Outputs "Thursday" (day 4)
            //The default keyword is optional and specifies some code to run if there is no case match
            int i = 0;

            //while
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            //do while
            int i1 = 0;
            do
            {
                Console.WriteLine(i1);
                i1++;
            }
            while (i1 < 5);

            //C# For Loop
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine(j);
            }
            //The foreach Loop
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            //The break statement can also be used to jump out of a loop.
            for (int i4 = 0; i4 < 10; i4++)
            {
                if (i4 == 4)
                {
                    break;
                }
                Console.WriteLine(i4);
            }

            //C# Continue
            /*The continue statement breaks one iteration(in the loop),
             * if a specified condition occurs, and continues with the next iteration in the loop.
            This example skips the value of 4:*/
            for (int m = 0; m < 10; m++)
            {
                if (m == 4)
                {
                    continue;
                }
                Console.WriteLine(m);
            }

            //Break and Continue in While Loop
            int k = 0;
            while (k < 10)
            {
                Console.WriteLine(k);
                k++;
                if (k == 4)
                {
                    break;
                }
            }

            //C# Arrays - To declare an array, define the variable type with square brackets
            string[] supercars;
            string[] supercars1 = { "Volvo", "BMW", "Ford", "Mazda" };
            int[] myNumarr = { 10, 20, 30, 40 };

            //Access the Elements of an Array
            string[] cars1 = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars1[0]); //by referring to the index number.

            //Change an Array Element
            cars1[0] = "Opel";

            //Array Length
            Console.WriteLine(cars1.Length);

            //Loop Through an Array - for loop
            for (int car_num = 0; car_num < cars.Length; car_num++)
            {
                Console.WriteLine(cars[car_num]);
            }

            //Loop Through an Array - The foreach Loop
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            //Sort Arrays
            string[] cars2 = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(cars2);
            foreach (string car in cars2)
            {
                Console.WriteLine(car);
            }

            //System.Linq Namespace - useful array methods, such as Min, Max, and Sum, can be found in the System.Linq namespace
            int[] myNumbers = { 5, 1, 8, 9 };
            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());  // returns the sum of elements

            //Other Ways to Create an Array
            // Create an array of four elements, and add values later
            string[] cars6 = new string[4];

            // Create an array of four elements and add values right away
            string[] cars7 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements without specifying the size
            string[] cars8 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements, omitting the new keyword, and without specifying the size
            string[] cars9 = { "Volvo", "BMW", "Ford", "Mazda" };

            //Note : that if you declare an array and initialize it later, you have to use the new keyword:
            // Declare an array
            string[] cars11;

            // Add values, using new
            cars11 = new string[] { "Volvo", "BMW", "Ford" };

        }//end of main function
    }
}