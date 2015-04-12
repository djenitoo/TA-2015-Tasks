using System;
//Declare two string variables and assign them with “Hello” and “World”. 
//Declare an object variable and assign it with the concatenation of the first 
//two variables (mind adding an interval). Declare a third string variable and initialize 
//it with the value of the object variable (you should perform type casting).

namespace _07.Exercise
{
    class StringObj
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            object helloWorld = hello + " " + world; // Object declaration.
            string greeting = (string)helloWorld; // Cast object to string.
            Console.WriteLine(helloWorld); // Print the type cast string.
        }
    }
}
