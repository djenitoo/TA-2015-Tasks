using System;
// Write an expression that calculates rectangle’s area by given width and height.

namespace _03.Exercise
{
    class RectangleArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the width:");
            double width = double.Parse(Console.ReadLine());        // Declaring the width
            Console.WriteLine("And the height:");
            double heighth = double.Parse(Console.ReadLine());      // and the height.

            double rectArea = width * heighth;                      // The expression that calculates the rectangle's area.

            Console.WriteLine("The area of the rectangle is: {0}",rectArea);    // The output result.

        }
    }
}
