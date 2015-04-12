using System;
using System.Numerics;

namespace _16.Tribonacci
{
    class Tribonacci
    {
        static void Main()
        {
            BigInteger firstEl =   BigInteger.Parse(Console.ReadLine());
            BigInteger secondEl =  BigInteger.Parse(Console.ReadLine());
            BigInteger thirdEl =   BigInteger.Parse(Console.ReadLine());
            BigInteger n =         BigInteger.Parse(Console.ReadLine());
            
            BigInteger sum = 0;
            if (n == 1)
            {
                Console.WriteLine(firstEl);
            }
            if (n == 2)
            {
                Console.WriteLine(secondEl);
            }
            if (n == 3)
            {
                Console.WriteLine(thirdEl);
            }
            else
            {
                for (int i = 3; i < n; i++)
                {
                    sum = firstEl + secondEl + thirdEl;
                    firstEl = secondEl;
                    secondEl = thirdEl;
                    thirdEl = sum;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
