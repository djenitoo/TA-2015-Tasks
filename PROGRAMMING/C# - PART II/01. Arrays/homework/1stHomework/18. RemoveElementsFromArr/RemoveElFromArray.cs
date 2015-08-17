using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Write a program that reads an array of integers and removes from it a minimal number of elements
 *  in such a way that the remaining array is sorted in increasing order.
    Print the remaining sorted array.
 *  6, 1, 4, 3, 0, 3, 6, 4, 5 ->	1, 3, 3, 4, 5
*/
namespace _18.RemoveElementsFromArr
{
    class RemoveElFromArray
    {
        static void Main(string[] args)
        {
            //int N = int.Parse(Console.ReadLine());
            //int[] arr = new int[N];
            //for (int i = 0; i < N; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            int[] arr = { 6, 1, 4, 3, 0, 3, 6, 4, 5 };
            int N = 9;
            int[] seqLenghts = new int[N];
            int[] arrIndexes = new int[N];
            int maxCount = 0;
            int bestEnd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int maxBefore = 0;
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] <= arr[i] && seqLenghts[j] > maxBefore)   // the hw whant it in increasing order, but 3,3 is not increasig, ugh
                    {
                        maxBefore = seqLenghts[j];
                        arrIndexes[i] = j;
                    }
                }
                seqLenghts[i] = maxBefore + 1;

                if (seqLenghts[i] > maxCount)
                {
                    maxCount++;
                    bestEnd = i;
                }
            }
            int nextIndex = bestEnd;
            int[] seqArr = new int[maxCount];

            for (int i = 0; i < seqArr.Length; i++)
            {
                seqArr[i] = arr[nextIndex];
                nextIndex = arrIndexes[nextIndex];
            }

            // print

            for (int i = seqArr.Length - 1; i >= 0; i--)
            {
                Console.Write(seqArr[i]);
                if (i != 0)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.Write(";");
                    Console.WriteLine();
                }
            }

        }
    }
}
