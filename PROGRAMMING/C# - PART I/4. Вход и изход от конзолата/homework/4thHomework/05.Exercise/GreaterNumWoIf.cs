using System;
// Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

namespace _05.Exercise
{
    class GreaterNumWoIf
    {
        static void Main(string[] args)
        {
            // Input
            Console.WriteLine("Please, enter the first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the second number: ");
            double b = double.Parse(Console.ReadLine());
            // Output & the Math.Max solution
            Console.WriteLine("The greater of {0} and {1} is: {2}", a,b, Math.Max(a,b));
        }
    }
}
