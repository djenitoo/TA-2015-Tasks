using System;
// Write a program that calculates the greatest common divisor (GCD) of given two numbers.
// Use the Euclidean algorithm (find it in Internet).


namespace _08.GCD
{
    class EuclidGCD
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a and b:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a < 0 || b < 0)
            {
                if (a < 0)
                {
                    a *= -1;
                }
                else
                {
                    b *= -1;
                }
            }
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            Console.WriteLine(a);
        }
    }
}
