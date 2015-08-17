using System;
// Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum.

namespace _07.Exercise
{
    class NNumSum
    {
        static void Main(string[] args)
        {
            // Input n
            Console.WriteLine("Please enter the count of numbers: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0 ;
            // Loop for inputing n numbers
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Please, enter a number {0}:",i);
                double x = double.Parse(Console.ReadLine());
                sum = sum + x;
            }
            // Output the sum
            Console.WriteLine("The sum of the numbers is: {0}", sum);
        }
    }
}
