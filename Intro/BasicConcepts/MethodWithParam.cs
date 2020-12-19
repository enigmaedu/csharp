using System;

namespace BasicConcepts
{
    class MethodWithParam
    {
        static void my_method(string fname)
        {
            Console.WriteLine("Example for method with Parameter - " + fname + " Smith");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("This is the programs entry point");
            my_method("John");

        }
    }
}