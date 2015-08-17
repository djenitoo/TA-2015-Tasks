using System;
// Write a program to print the first n members of the sequence of 
// Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …


namespace _09.Exercise
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N");
            int N = int.Parse(Console.ReadLine());
            // Declaring member 0 & 1
            decimal member0 = 0;
            decimal member1 = 1;

            // Output
            Console.Write("{0}, {1}, ", member0, member1);
            // Loop for members 2-99
            for (int i = 2; i < N; i++)
            {
                decimal x = member0 + member1;
                member0 = member1;
                member1 = x;
                Console.Write("{0}, ", x);
            }
            Console.WriteLine("...");
        }
    }
}
