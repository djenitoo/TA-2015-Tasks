using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Write a program, that reads from the console an array
 * of N integers and an integer K, sorts the array and 
 * using the method Array.BinSearch() 
 * finds the largest number in the array which is ≤ K. 
 * */
namespace _04.Array_Bin_Search
{
    class ArrayBinSearch
    {
        static void Main()
        {
            // Read
            //Console.Write("N= ");
            //int N = int.Parse(Console.ReadLine());
            //Console.Write("K= ");
            //int K = int.Parse(Console.ReadLine());

            //int[] array = new int[N];
            //for (int i = 0; i < N; i++)
            //{
            //    Console.Write("Element {0}: ", i);
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            int[] array = { 3, 2, 1, 5, 6, 2, 0 };
            int K = 4;
            int kOrig = K;
            int N = 7;
            // Sort the array
            Array.Sort(array);

            //Print sorted array
            for (int i = 0; i < N; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            //Search the array for the el<=K
            int index = -1;
            while ((index < 0) && (K >= array[0]))
            {
                index = Array.BinarySearch(array, K);
                if (index < 0)
                {
                    K--;
                }
            }
            Console.WriteLine();
            //Output
            if (index < 0)
            {
                Console.WriteLine("There is no number<=K!");
            }
            Console.WriteLine("The index of the biggest number <=" + kOrig +" is: " + index + "\r\narray[" + index + "]= " + array[index]);
        }
    }
}
