using System;
using System.Numerics;
using System.Collections.Generic;

namespace _08._NumbersAsArrays
{
    class NumbersAsArrays
    {
        static void Main(string[] args)
        {
            BigInteger numberOne = BigInteger.Parse(Console.ReadLine());
            BigInteger numberTwo = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(AddsNumbers(numberOne, numberTwo));
        }

        private static string AddsNumbers(BigInteger numberOne, BigInteger numberTwo)
        {
            List<int> arrOne = new List<int>();
            List<int> arrTwo = new List<int>();
            List<int> result = new List<int>();
            BigInteger tempOne = numberOne;
            BigInteger tempTwo = numberTwo;

            while (tempOne != 0)
            {
                int temp = (int)(tempOne % 10);
                arrOne.Add(temp);
                tempOne /= 10;
            }
            while (tempTwo != 0)
            {
                int temp = (int)(tempTwo % 10);
                arrTwo.Add(temp);
                tempTwo /= 10;
            }
            // ---------------
            int end;
            if (arrOne.Count != arrTwo.Count)
            {
                end = Math.Min(arrOne.Count, arrTwo.Count);
            }
            else
            {
                end = arrOne.Count;
            }
            int next = 0;
            for (int i = 0; i < end; i++)
            {
                int temp = next + arrOne[i] + arrTwo[i];
                result.Add(temp % 10);
                next = temp / 10;
            }
            // ---------------
            if (arrOne.Count > end)
            {
                for (int i = end; i < arrOne.Count; i++)
                {
                    int temp = arrOne[i] + next;
                    result.Add(temp % 10);
                    next = temp / 10;
                }
            }
            else if(arrTwo.Count > end)
            {
                for (int i = end; i < arrTwo.Count; i++)
                {
                    int temp = arrTwo[i] + next;
                    result.Add(temp % 10);
                    next = temp / 10;
                }
            }
            string str = "";
            for (int i = result.Count - 1; i >= 0; i--)
            {
                str += result[i];
            }

            return str;
        }
    }
}
