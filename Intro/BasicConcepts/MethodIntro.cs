using System;

namespace BasicConcepts

{
    class MethodIntro
    {
        static void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }

        static void Main(string[] args)
        {
            MyMethod();
            MyMethod();
            MyMethod();
        }
    }
}