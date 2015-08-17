using System;
// Write a program that finds the biggest of three integers using nested if statements.

namespace _03.Exercise
{
    class TheBiggestVar
    {
        static void Main(string[] args)
        {
            // Input
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            // declaring the variable that will hold the biggest var, 
            // firstly we assign it with the value of a.
            double biggestNum = a;

            if (biggestNum < b || biggestNum < c)
            {
                biggestNum = b;
                if (biggestNum < c)
                {
                    biggestNum = c;
                }
            }
            // The output
            Console.WriteLine("The biggest number of {0}, {1}, {2} is: {3}", a, b, c, biggestNum);
        }
    }
}
