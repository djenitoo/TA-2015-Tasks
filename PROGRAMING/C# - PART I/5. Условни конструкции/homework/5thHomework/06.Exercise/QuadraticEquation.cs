using System;
// Write a program that enters the coefficients a, b and c of a quadratic equation
//		a*x2 + b*x + c = 0


namespace _06.Exercise
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            // Input
            Console.WriteLine("Please, enter the first coefficient: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the second coefficient: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the third coefficient: ");
            int c = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("This is not a quadratic equation !");
            }
            else
            {
                // The equation of D
                double d = Math.Pow(b, 2) - 4 * a * c;
                // Declaring the roots
                double root1, root2;
                // If statement with 3 possibilities & output
                if (d < 0)
                {
                    Console.WriteLine("The quadratic equation has no solutions!");
                }
                if (d == 0)
                {
                    Console.WriteLine("Root 1 = Root 2 = {0}", -b / (2 * a));
                }
                else
                {
                    root1 = ((-b) - Math.Sqrt(d)) / 2 * a;
                    root2 = ((-b) + Math.Sqrt(d)) / 2 * a;
                    Console.WriteLine("The roots are {0} and {1}", root1, root2);
                }
            } 
        }
    }
}
