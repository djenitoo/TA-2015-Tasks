using System;

/*
 * Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].
 *  {1, 2, 3} 3
    {1, 3, 2}
    {2, 1, 3}
    {2, 3, 1}
    {3, 1, 2}
    {3, 2, 1}
 * */
class PermutationOfSet
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i <= N; i++)
            {
                Console.Write("{" + i + ", ");

            }
        }
    }
