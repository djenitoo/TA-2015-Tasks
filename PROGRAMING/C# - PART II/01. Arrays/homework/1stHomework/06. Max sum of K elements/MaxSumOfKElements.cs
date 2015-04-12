using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Write a program that reads two integer numbers N and K
// and an array of N elements from the console. 
// Find in the array those K elements that have maximal sum.

namespace _06.Max_sum_of_K_elements
{
    class MaxSumOfKElements
    {
        static void Main()
        {
            Console.Write("Enter N: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            int K = int.Parse(Console.ReadLine());

            int[] array = new int[N];
            int bestSum = 0;
            int beginIndex = 0;

            for (int i = 0; i < N; i++)
            {
                Console.Write("Element {0}: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            array = array.OrderByDescending(x => x).ToArray();
            int sum = 0;
            for (int i = 0; i < K; i++)
            {
                sum += array[i];
                
            }

            
            Console.WriteLine("The sum of the biggest {0} elements is: {1}", K, sum);
        }
    }
}
