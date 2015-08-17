/*Problem 1. Shapes

    Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
    Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of 
 *  the figure (height * width for rectangle and height * width/2 for triangle).
    Define class Square and suitable constructor so that at initialization height must be kept equal 
 *  to width and implement the CalculateSurface() method.
    Write a program that tests the behaviour of the CalculateSurface() method for 
 *  different shapes (Square, Rectangle, Triangle) stored in an array.
*/
namespace _01.Shapes
{
    using System;

    class Test
    {
        // uncomment for square with 2 diff sides
        static void Main()
        {
            Shape[] shapes = {
                                 new Triangle(5.13, 7.84),
                                 new Rectangle(8.02, 7),
                                 new Square(12.05)/*, new Square(15.05, 16.03)*/
                             };

            foreach (var item in shapes)
            {
                Console.WriteLine(item.GetType().Name + " " + item.CalculateSurface());
            }
        }
    }
}
