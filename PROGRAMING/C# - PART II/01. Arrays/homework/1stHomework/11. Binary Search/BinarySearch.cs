using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Write a program that finds the index of given element
// in a sorted array of integers by using
// the binary search algorithm (find it in Wikipedia).

namespace _11.Binary_Search
{
    class BinarySearch
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int startSearch = 0;
            int endSearch = array.Length - 1;
            Console.Write("Enter 1 <= number <= 20 : ");
            int key = int.Parse(Console.ReadLine());
            int middle = endSearch / 2;
            while (startSearch < endSearch)
            {
                middle = (endSearch - middle) / 2 + startSearch;
                if (array[middle] == key)
                {
                    Console.WriteLine("The number's index is: " + middle);
                    break;
                }
                else
                {
                    if (key < array[middle])
                    {
                        endSearch = middle - 1;
                    }
                    else
                    {
                        startSearch = middle + 1;
                    }
                }
                if (key < array[startSearch] || key > array[endSearch])
                {
                    Console.WriteLine("Number NOT found!");
                    break;
                }
            }
        }
    }
}
