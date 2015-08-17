using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *  We are given an array of integers and a number S.
 *  Write a program to find if there exists a subset of the elements of the array that has a sum S
 * 
 *  |2, *1, *2, 4, 3, *5, 2, *6 |14| yes|
 */
namespace _16.SubsetWithSumS
{
    class SubsetWithSumS            
    {
        static void Main(string[] args)
        {
            List<int> sequence = new List<int> { 2, 1, 2, 4, 3, 5, 2, 6 };
            int S = 14;
            //S = int.Parse(Console.ReadLine());

            int subsetCount = (int)Math.Pow(2, sequence.Count);
            bool thereIsSubset = false;

            for (int i = 1; i <= subsetCount; i++)
            {
                int tempSum = 0;
                int bits = i;
                for (int j = 0; j < sequence.Count; j++)
                {
                    if (bits % 2 == 1)
                    {
                        tempSum += sequence[j];
                    }
                    bits >>= 1;
                }
                if (tempSum == S)
                {
                    Console.WriteLine("yes");
                    thereIsSubset = true;
                    break;
                }
            }

            if (!thereIsSubset)
            {
                Console.WriteLine("no");
            }
        }
    }
}
