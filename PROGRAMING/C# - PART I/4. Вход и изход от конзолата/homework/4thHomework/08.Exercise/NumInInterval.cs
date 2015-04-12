using System;
// Write a program that reads an integer number n from the console and prints all the numbers 
// in the interval [1..n], each on a single line.


namespace _08.Exercise
{
    class NumInInterval
    {
        static void Main(string[] args)
        {
            // Input n
            Console.WriteLine("Please enter a number: ");
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine("The numbers in the interval [1-{0}] are:",n);
            // Output loop
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
