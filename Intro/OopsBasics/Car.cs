/*
Procedural programming - writing procedures or methods that 
perform operations on the data.
Object-oriented programming - creating objects that 
contain both data and methods.

-A class is a template for objects, and an object is an instance of a class.
-When the individual objects are created, they inherit all the 
variables and methods from the class.
Examples: 
Fruit is class and Apple, Mango and Banana are its instances.
Car is a class and Volvo,Audio and Toyota are its instances.
-Fields and methods inside classes are often referred to as "Class Members".


*/

//create class and an instance of it
using System;

namespace OopsBasics
{
    class Car
    {
        /*
        -public keyword-access modifier, specifies that the color variable/field of Car 
        is accessible for other classes as well.
        -A static method can be accessed without creating an object of the class, 
        while public methods can only be accessed by objects.
        -Therfore, class method speed here is decalred as public, and not static
        */

        public string color = "Red"; //field
        public int YearOfMgf; //define the field values later
        public string ModelName; //define the field values later

        public void speed() //method
        {
            Console.WriteLine("This cars has a max speed of 250 miles/hr!");
        }
        static void Main(string[] args) //Main method
        {
            Console.WriteLine("This is the entry point of the program!");
            Car my_object = new Car();
            Console.WriteLine(my_object.color);
            Car my_object2 = new Car();
            my_object2.color = "Green"; //Modify the field value after creation
            Console.WriteLine(my_object2.color);//Multiple objects example
            
            Car Toyota = new Car();
            Toyota.color = "Black";
            Toyota.YearOfMgf = 1988;
            Toyota.ModelName = "Camry";
            Console.Write("My car modle is ");
            Console.WriteLine(Toyota.ModelName);//calss method is called here
            Toyota.speed();
        }
    }

}