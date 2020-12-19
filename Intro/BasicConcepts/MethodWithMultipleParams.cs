using System;

namespace BasicConcepts
{
    class MethodWithMultipleParams
    {
        static void my_method(string name, int age)
        {
            Console.WriteLine("My name is " + name + " and my age is " + age);
        }
        
        static void Main(string [] args)
        {
            Console.WriteLine("This is the entry point of the program!");
            Console.WriteLine("Calling the method with params now ...");
            my_method("John", 24);
            my_method("Kevin", 21);
            my_method("Mathew", 23);
        }
    }
}