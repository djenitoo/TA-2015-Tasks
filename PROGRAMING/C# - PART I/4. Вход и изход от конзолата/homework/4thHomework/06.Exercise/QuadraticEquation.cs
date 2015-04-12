using System;
// Write a program that reads the coefficients a, b and c of 
// a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).


namespace _06.Exercise
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            // Input
            Console.WriteLine("Please, enter the first coefficient: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the second coefficient: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the third coefficient: ");
            double c = double.Parse(Console.ReadLine());
            
            // The equation of D
            double d = b * b + (-4*a*c);
            
            // If statement with 3 possibilities & output
            if (d < 0)
            {
                Console.WriteLine("The quadratic equation has no solutions!");
            }
            else if (d == 0)
            {
                Console.WriteLine("Root 1 = Root 2 = {0}", -b / (2 * a));
            }
            else
            {
                double root1 = (-b - Math.Sqrt(d)) / (2 * a);
                double root2 = (-b + Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("The roots are {0} and {1}", root1, root2);
            }
        }
    }
}
