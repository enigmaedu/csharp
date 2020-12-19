using System;

namespace BasicConcepts
{
    class MethodWithReturnVal
    {
        static int MyMethod (int x)
        {
            Console.WriteLine("This method retruns a value!!!");
            return 5 + x;
        }
        static void Main(string [] args)
        {
            Console.WriteLine("This is the entry point of the program!");
            Console.WriteLine(MyMethod(4));

        }

    }
}