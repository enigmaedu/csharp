/*
 * useful when you have multiple parameters with default values, 
 and you only want to specify one of them when you call it.
*/

using System;
namespace BasicConcepts
{
    class MethodWithNamedArguments
    {
        static string my_method(string fname, string lname, string mname = "N/A")
            //Optional arguments should be placed at the end 
        {
        return  fname + " " + mname + " " + lname;
        }
        
        static void Main(string[] args)
        {
        Console.WriteLine("This is the entry point of the program");
        string fullname = my_method(fname:"John",lname:"Smith");//here mname takes the default value
        Console.WriteLine(fullname);
        string fullname1 = my_method(fname: "Mathew", mname:"Aus",lname: "Hayden");
        Console.WriteLine(fullname1);
        }
    }
}