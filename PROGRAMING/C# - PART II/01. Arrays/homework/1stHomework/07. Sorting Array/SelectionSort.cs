using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Sorting an array means to arrange its elements
// in increasing order. Write a program to sort an array.
// Use the "selection sort" algorithm: Find the smallest element, 
// move it at the first position, find the smallest from the rest,
// move it at the second position, etc.

namespace _07.Sorting_Array
{
    class SelectionSort
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

            Console.WriteLine("The array at first: ");
            for (int i = 0; i < arrLength; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < arrLength; i++)
            {
                int j = i;
                while (j < arrLength)
                {
                    if (array[i] > array[j])
                    {
                        int middle = array[i];
                        array[i] = array[j];
                        array[j] = middle;
                    }
                    j++;
                }
            }
            Console.WriteLine("The SORTED array: ");
            for (int i = 0; i < arrLength; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
