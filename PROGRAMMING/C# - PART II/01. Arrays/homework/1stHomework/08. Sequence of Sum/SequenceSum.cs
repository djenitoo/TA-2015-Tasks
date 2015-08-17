using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Write a program that finds the sequence of maximal sum in given array. Example:
//	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
//	Can you do it with only one loop (with single scan through the elements of the array)?

namespace _08.Sequence_of_Sum
{
    class SequenceSum
    {
        static void Main()
        {
            Console.Write("Please enter the length of the array: ");
            int arrLength = int.Parse(Console.ReadLine());
            int[] array = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.Write("Element {0}: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            // Kadane's algorithm

            int maxSoFar = array[0];
            int maxEnd = array[0];
            int lenght = 0;
            int end = 0;
            int bestlenght = 0;
            int bestEnd = 0;

            for (int i = 1; i < arrLength; i++)
            {
                if (maxEnd < 0)
                {
                    maxEnd = array[i - 1];
                }
                else
                {
                    maxEnd += array[i];
                    lenght++;
                }
                end = i+1;
                if (maxEnd > maxSoFar)
                {
                    maxSoFar = maxEnd;
                    bestlenght = lenght;
                    bestEnd = end;
                }
            }

            for (int i = bestEnd - bestlenght; i < bestEnd; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
