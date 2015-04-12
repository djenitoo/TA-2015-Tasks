using System;
using System.Linq;
// Write a method that asks the user for his name and prints “Hello, <name>”
// (for example, “Hello, Peter!”). Write a program to test this method.


namespace _01._MethodHelloName
{
    public class HelloName
    {
        public static string Name(string name)
        {
            return "Hello, " + name + "!";

        }
        static void Main()
        {
            string name = "What";
            Console.WriteLine(Name(name));
        }
    }
}
