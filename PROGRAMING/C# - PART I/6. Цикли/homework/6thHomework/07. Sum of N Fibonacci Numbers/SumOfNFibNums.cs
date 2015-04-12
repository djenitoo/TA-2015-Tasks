using System;
// Write a program that reads a number N and calculates the sum of 
// the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3,
// 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
// Each member of the Fibonacci sequence (except the first two) is 
// a sum of the previous two members.


namespace _07.Sum_of_N_Fibonacci_Numbers
{
    class SumOfNFibNums
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of Fibonacci members:");
            int n = int.Parse(Console.ReadLine());
            decimal member0 = 0;
            decimal member1 = 1;
            decimal sum = member0 + member1;

            // Loop for members N
            for (int i = 2; i < n; i++)
            {
                decimal x = member0 + member1;
                member0 = member1;
                member1 = x;
                sum = sum + x;
            }
            Console.WriteLine("The sum of the {0} members of Fibonacci sequence is: {1}", n, sum);
        }
    }
}
