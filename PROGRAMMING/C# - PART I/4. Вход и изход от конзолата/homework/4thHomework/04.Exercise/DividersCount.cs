using System;
// Write a program that reads two positive integer numbers and prints how many numbers p 
// exist between them such that the reminder of the division by 5 is 0 (inclusive). 
// Example: p(17,25) = 2.


namespace _04.Exercise
{
    class DividersCount
    {
        static void Main(string[] args)
        {
            // Input first and second number
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int p = 0;
            // Loop searching if the numbers between a & b are %5 = 0
            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0)
                {
                    p++;
                }
            }
            // Output
            Console.WriteLine("The numbers that divide by 5 between {0} and {1} is: {2}", a, b, p);
        }
    }
}
