using System;
// Write a program that prints all the numbers from 1 to N.

namespace _01.Print_N_Numbers
{
    class PrintNNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter n: ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
    }
}
