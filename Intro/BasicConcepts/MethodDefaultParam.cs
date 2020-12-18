
using System;

namespace BasicConcepts
{
    class MethodParamArgs
    {
        static void MyMethod(string fname)
        {
            Console.WriteLine(fname + " Refsnes");
        }

        static void Main(string[] args)
        {
            MyMethod("Kevin");
            MyMethod("Pam");
            MyMethod("Anja");
        }
    }
}
