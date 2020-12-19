
using System;

namespace BasicConcepts
{
    class MethodDefaultParam
    {
        static void MyMethod(string country = "Norway")
        {
            Console.WriteLine(country);
        }

        static void Main(string[] args)
        {
            MyMethod("Swed  en");
            MyMethod("India");
            MyMethod();
            MyMethod("USA");
        }
    }
}   