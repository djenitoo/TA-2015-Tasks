using System;
// Write a program that finds the greatest of given 5 variables.

namespace _07.Exercise
{
    class BiggestOfFive
    {
        static void Main(string[] args)
        {
            // Input
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());

            double max = a;

            if (max < b || max < c || max < d || max < e)
            {
                max = b;

                if (max < c || max < d || max < e)
                {
                    max = c;

                    if (max < d || max < e)
                    {
                        max = d;

                        if (max < e)
                        {
                            max = e;
                        }
                    }
                }
            }
            

            // Output
            Console.WriteLine("The biggest number of {0}, {1}, {2}, {3} and {4} is: {5}", a, b, c, d, e, max);
        }
    }
}
