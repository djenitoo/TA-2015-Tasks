using System;
// Write a program that reads the radius r of a circle and prints its perimeter and area.

namespace _02.Exercise
{
    class CirclePerimeterAndArea
    {
        static void Main(string[] args)
        {
            // Declaring Pi
            double Pi = 3.1415926;
            // Declaring the radius
            Console.WriteLine("Enter the radius of the circle:");
            double radius = double.Parse(Console.ReadLine());
            // Perimeter
            double perimeter = 2 * Pi * radius;
            // Area
            double area = Pi * radius * radius;
            Console.WriteLine("The perimeter of the circle is: {0:F2},\n\rand the area is: {1:F2}", perimeter, area);
        }
    }
}
