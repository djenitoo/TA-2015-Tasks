using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Write a program that finds the maximal sequence of equal elements in an array.
//		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

namespace _04.Biggest_sequence
{
    class BiggestSeq
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

            int count = 1;
            int maxCount = 0;
            int number = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i+1])
                {
                    count++;
                }
                else
                {
                    if (maxCount < count)
                    {
                        maxCount = count;
                        number = array[i];
                    }
                    count = 1;
                }
            }
            if (maxCount < count)
            {
                maxCount = count;
                number = array[array.Length - 1];
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(number);
                if (i != maxCount - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
