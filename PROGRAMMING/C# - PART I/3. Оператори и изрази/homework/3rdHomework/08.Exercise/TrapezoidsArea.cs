using System;
// Write an expression that calculates trapezoid's area by given sides a and b and height h.

namespace _08.Exercise
{
    class TrapezoidsArea
    {
        static void Main(string[] args)
        {
            // Input a,b and h
            Console.WriteLine("Please, enter the first side:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the second side:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the height:");
            double h = double.Parse(Console.ReadLine());
            // The expression that calculates the trapezoid's area
            double tArea = ((a + b) / 2) * h;
            // Output
            Console.WriteLine("The area of trapezoid is: "+ tArea);
        }
    }
}
