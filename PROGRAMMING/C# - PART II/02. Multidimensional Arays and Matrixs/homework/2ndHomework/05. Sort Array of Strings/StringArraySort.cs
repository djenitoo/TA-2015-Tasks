using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * You are given an array of strings. Write a method that sorts the array by the length
 * of its elements (the number of characters composing them).
 */
namespace _05.Sort_Array_of_Strings
{
    class StringArraySort
    {
        static void ArraySort(string[] array, int N)
        {
            for (int i = 0; i < N - 1; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (array[i].Length > array[j].Length)
                    {
                        string p;
                        p = array[i];
                        array[i] = array[j];
                        array[j] = p;
                    }
                }
            }

            PrintArray(array);
        }
        static void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        static void Main()
        {
            Console.Write("Lenght of the array: ");
            int N = int.Parse(Console.ReadLine());
            string[] array = new string[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write("Element {0}: ", i);
                array[i] = Console.ReadLine();
            }
            ArraySort(array, N);
        }
    }
}
