/*Multiple methods can have the same name with different parameters
Multiple methods can have the same name as long as the number 
and/or type of parameters are different.
*/

using System;

namespace BasicConcepts
{
    class MethodOverloading
    {
        static int PlusMethod(int num1,int num2)
        {
            return num1 + num2;
        }

        static double PlusMethod(double num1,double num2)
        {
            return num1 + num2;
        }
        static void Main (string[] args)
        {
            Console.WriteLine("This is the entry point of the program!");
            int int_numsum = PlusMethod(3, 4);
            Console.WriteLine("sum of int numbers: " + int_numsum);
            double double_numsum = PlusMethod(3.1, 4.1);
            Console.WriteLine("sum of double numbers: " + double_numsum);
        }
    }
}