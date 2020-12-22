using System;

namespace OopsBasics
{
    class MainProgram 
    {
        static void Main(string [] args)
        {
            Console.WriteLine("This is the entry point of the program.");   
            Console.WriteLine("Create an instance of the class car.");
            //Using Multiple calsses - use the class cars here
            Car myObj = new Car();
            Console.WriteLine("New instance created!");
            Console.Write("The color of the new instance of the class car is ");
            Console.WriteLine(myObj.color);
        }
    }
}