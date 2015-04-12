using System;
using System.Collections.Generic;
using System.Linq;
// Write a program that reads two arrays from the console and compares them element by element.

namespace _02.Array_Comparison
{
    class ArrayComparison
    {
        static void Main()
        {
            Console.Write("Please, enter the size of the first array: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Please, enter the size of the second array: ");
            int M = int.Parse(Console.ReadLine());

            int[] firstArr = new int[N];
            int[] secondArr = new int[M];

            bool check = true;

            if (N != M)
            {
                Console.WriteLine("The arrays are not with the same length!");
            }
            else
            {
                for (int i = 0; i < firstArr.Length; i++)
                {
                    Console.Write("Please enter element {0} of the first array: ", i);
                    firstArr[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < secondArr.Length; i++)
                {
                    Console.Write("Please enter element {0} of the second array: ", i);
                    secondArr[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < firstArr.Length; i++)
                {
                    if (firstArr[i] != secondArr[i])
                    {
                        check = false;
                        break;
                    }
                }
                Console.WriteLine("The arrays are equal? -> " + check);
            }
        }
    }
}
