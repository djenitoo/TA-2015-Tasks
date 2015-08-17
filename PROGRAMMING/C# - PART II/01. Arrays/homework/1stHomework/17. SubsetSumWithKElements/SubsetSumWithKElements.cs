using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.SubsetSumWithKElements
{
    class SubsetSumWithKElements
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //int K = int.Parse(Console.ReadLine());
            //int S = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            int n = 7;
            int k = 3;
            int s = 5;
            int[] arr = { 4, 3, 1, 2, 1, 3, 5 };
            bool check = false;
            int count = (int)Math.Pow(2, n);

            for (int i = 1; i < count; i++)
            {
                int bits = i;
                int tempSum = 0;
                int elCount = 0;
                for (int j = 0; j < n; j++)
                {
                    if (bits % 2 == 1)
                    {
                        tempSum += arr[j];
                        elCount++;
                    }
                    bits >>= 1;
                }
                if (tempSum == s && elCount == k)
                {
                    check = true;
                    Console.WriteLine("yes");
                    break;
                }
                tempSum = 0;
                elCount = 0;
            }

            if (!check)
            {
                Console.WriteLine("no");
            }
        }
    }
}
