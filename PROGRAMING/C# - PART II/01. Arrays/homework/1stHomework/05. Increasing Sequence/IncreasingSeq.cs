using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Write a program that finds the maximal increasing sequence in an array. 
// Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.


namespace _05.Increasing_Sequence
{
    class IncreasingSeq
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the length of the array: ");
            int arrLength = int.Parse(Console.ReadLine());
            int[] array = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.Write("Element {0}: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            int bestStart = 0;
            int bestEnd = 0;

            for (int i = 0; i < arrLength - 2; i++)
            {
                if (array[i] + 1 == array[i + 1])
                {
                    int start = i;
                    while (array[i] + 1 == array[i + 1] && i < arrLength - 1)
                    {
                        i++;
                    }
                    int end = i;
                    if (bestEnd - bestStart < end - start)
                    {
                        bestStart = start;
                        bestEnd = end;
                    }
                }
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The biggest increasing sequence in the array is: ");
            for (int i = bestStart; i <= bestEnd; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
