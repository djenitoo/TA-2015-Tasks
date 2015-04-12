using System;
// Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

namespace _06.Exercise
{
    class PointWithinCircle
    {
        static void Main(string[] args)
        {
            // Input x
            double x = double.Parse(Console.ReadLine());
            // Input y
            double y = double.Parse(Console.ReadLine());
            // Radius
            int radius = 2;
            // The expression(by Pythagorean Theorem, because the center is 0,0) and the output.
            Console.WriteLine((x*x)+(y*y)<=radius*radius ? "The point is within the circle." : "The point is NOT within the circle.");
        }
    }
}
