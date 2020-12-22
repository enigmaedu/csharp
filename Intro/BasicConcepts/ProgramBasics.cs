using System;
using System.Linq;

namespace BasicConcepts
{
    class ProgramBasics
    {
        static void Main(string[] args)
        {
            //Write vs Writeline
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello Again!!!");
            Console.Write("Hello World. ");
            Console.Write("Hello Again!!!");
            
            //Comments//

            //Single line comment
            /*
             Multi line comment
             Multi line comment
             */
            
            //Variables//

            //String variable
            string name = "John";
            Console.WriteLine(name);
            int myNum = 15;
            Console.WriteLine(myNum);
            //Constants
            const int myNumConst = 20;
            Console.WriteLine(myNumConst);
            //other vaiables
            int my_num = 1;
            double myDoubleNum = 5.99D;
            char myLetter = 'D';
            bool myBool = true;
            //Display variables-Using WriteLine() method
            Console.WriteLine(myLetter);
            Console.WriteLine("Hello " + name);
            //To combine both text and a variable, use the + character
            Console.WriteLine("Variable assignment test --> " + myDoubleNum + " " + myLetter + " " + myBool);
            int x = 5, y = 6, z = 50;
            Console.WriteLine(x + y + z); //addition
            int myInt = 9;

            //Type conversion//

            // Implicit casting: conversion from larger DT to smaller DT. Example:Int to Double
            double myDouble = myInt;
            //Explicit casting: conversion from smaller DT to a larger DT. Example:Double to Int
            double myDouble1 = 9.78;
            int myInt1 = (int)myDouble1;    // Manual casting: double to int
            //Type conversion using convert method
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);

            //Get user input//
           
            Console.WriteLine("Enter username:");
            // Type your username and press enter
            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();
            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Username is: " + userName);

            //C# Operators//

            //Arithmetic Operators
            //+, -, *, /, %, ++, --
            //Assignment Operators
                //=, +=, -=, *=, /=, %=, &=, |=, ^=, >>=, <<=
            //Comparison Operators
                //==, !=, >, <, >=, <=
            //Logical Operators
                //&&, ||, !

            //C# math//

            Math.Max(5, 10);
            Math.Min(5, 10);
            Math.Sqrt(64);
            Math.Abs(-4.7);
            Math.Round(9.99);

            //C# Strings//
            
            string txt = "Hello World";
            //String Length
            string txt1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: " + txt1.Length);
            //case conversion
            Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(txt.ToLower());   // Outputs "hello world"
            
            //String Concatenation
            //Approach 1
            string firstName = "John ";
            string lastName = "Doe";
            string name1 = firstName + lastName;
            Console.WriteLine(name1);
            //Approach 2
            string name2 = string.Concat(firstName, lastName);
            Console.WriteLine(name2);
            //Approach 3
            /*Another option of string concatenation, is string interpolation,
                which substitutes values of variables into placeholders in a string.
            */
            Console.WriteLine("String Interpolation example is below:");
            string name3 = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name3);
            
            //Accessing Strings
            //Refering to index number
            string myString = "Hello";
            Console.WriteLine(myString[0]); // Outputs "H"
            //Find the index position of a specific character
            Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"

            //Special Characters
            // The backslash (\) escape character turns special characters into string characters:
            //string txt = "We are the so-called "Vikings" from the north."; //Incorrect
            string txt2 = "We are the so-called \"Vikings\" from the north.";
            Console.WriteLine(txt2);
            //Other useful escape characters in C#
            // \n, \t, \b


            //Boolean Expression//

            //Boolean - can only have one of two values
            int x1 = 10;
            int y1 = 9;
            Console.WriteLine(x1 > y1); // returns True, because 10 is higher than 9
            int x2 = 10;
            Console.WriteLine(x2 == 10); // returns True, because the value of x is equal to 10
            Console.WriteLine(10 == 15); // returns False, because 10 is not equal to 15

            //C# if else//

            //if
            if (20 > 18)
            {
                Console.WriteLine("20 is greater than 18");
            }

            //if else
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

            //C# Switch//

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


            //while loop//
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            //do while loop
            int i1 = 0;
            do
            {
                Console.WriteLine(i1);
                i1++;
            }
            while (i1 < 5);

            //C# For Loop//
            
            //simple for loop
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine(j);
            }
            //The foreach Loop
            //Declare a array and then loop through its contents
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            //C# Break and Continue//

            //C# break
            //The break statement can also be used to jump out of a loop.
            for (int i4 = 0; i4 < 10; i4++)
            {
                if (i4 == 4)
                {
                    break;
                }
                Console.WriteLine(i4);
            }

            //C# continue
            /*The continue statement breaks one iteration(in the loop),
             * If a specified condition occurs, and continues with the next iteration in the loop.
             * This example skips the value of 4:*/
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

            //C# Arrays//
            
            //To declare an array, define the variable type with square brackets
            string[] supercars;
            string[] supercars1 = { "Volvo", "BMW", "Ford", "Mazda" };
            int[] myNumarr = { 10, 20, 30, 40 };

            //Access the Elements of an Array
            Console.WriteLine(supercars1[0]); //by referring to the index number.

            //Change an Array Element
            supercars1[0] = "Opel";

            //Array Length
            Console.WriteLine(supercars1.Length);

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

            //System.Linq Namespace - useful array methods - Min, Max, and Sum
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