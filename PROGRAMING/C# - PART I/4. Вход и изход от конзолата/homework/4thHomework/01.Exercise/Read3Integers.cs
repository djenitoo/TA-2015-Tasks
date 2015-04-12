using System;
// Write a program that reads 3 integer numbers from the console and prints their sum.

namespace _01.Exercise
{
    class Read3Integers
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter the first integer: ");
            // Declaring the first, second and third number
            double a = double.Parse(Console.ReadLine());
            
            Console.Write("Please, enter the second integer: "); 
            double b = double.Parse(Console.ReadLine());
            
            Console.Write("Please, enter the third integer: ");
            double c = double.Parse(Console.ReadLine());
            // Output
            Console.WriteLine();
            Console.WriteLine("The sum of the numbers you entered is: {0}", a+b+c);
            
        }
    }
}
