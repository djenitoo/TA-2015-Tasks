using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Write a program that finds in given array of integers a sequence of given sum S (if present). 
// Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}	

namespace _10.Find_sequence_of_sum
{
    class SeqSumToFind
    {
        static void Main()
        {
            Console.Write("Please, enter the length of the array: ");
            int arrLength = int.Parse(Console.ReadLine());
            Console.Write("Please, enter the Sum: ");
            int sum = int.Parse(Console.ReadLine());
            int[] array = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.Write("Element {0}: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            
            for (int i = 0; i < arrLength - 1; i++)
            {
                int currentSum = array[i];
                int begin = i;
                for (int j = i + 1; j < arrLength; j++)
                {
                    currentSum += array[j];
                    int end = j;
                    if (currentSum == sum)
                    {
                        Console.Write("Sum = {0} -> ", sum);
                        for (int p = begin; p <= end; p++)
                        {
                            Console.Write(array[p] + " ");
                        }
                        Console.WriteLine();
                        break;
                    }
                }
            }
        }
    }
}
