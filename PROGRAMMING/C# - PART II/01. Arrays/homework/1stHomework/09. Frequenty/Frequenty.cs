using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Write a program that finds the most frequent number in an array. Example:
//	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

namespace _09.Frequenty
{
    class Frequenty
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter the length of the array: ");
            int arrLength = int.Parse(Console.ReadLine());
            int[] array = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.Write("Element {0}: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            int bestCount = 0;
            
            int bestNumber = 0;

            for (int i = 0; i < arrLength - 1; i++)
            {
                int count = 1;
                int number = 0;
                for (int j = i+1; j < arrLength; j++)
                {
                    if (array[i] == array[j])
                    {
                        number = array[i];
                        count++;
                    }
                    if (bestCount < count)
                    {
                        bestNumber = number;
                        bestCount = count;
                    }
                }
            }

            Console.WriteLine("The most frequent number is {0} ({1} times).", bestNumber, bestCount);
        }
    }
}
