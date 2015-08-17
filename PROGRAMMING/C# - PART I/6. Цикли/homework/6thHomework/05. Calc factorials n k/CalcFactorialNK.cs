using System;
// Write a program that calculates N! / (K! * (N-K)!) for given N and K (1<K<N<100).

namespace _05.Calc_factorials_n_k
{
    class CalcFactorialNK
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter n! and k! (1<n<k):");
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            //int nFact = 1;
            //int kFact = 1;
            long rez = 0;
            long nkFact = 1;
            long up = 1;
            for (int i = k+1; i <= n; i++)
            {
                up *= i;
            }
            for (int i = 1; i <= n-k; i++)
            {
                nkFact *= i;
            }
            rez = up / nkFact;
            //for (int i = 1; i <= n; i++)
            //{
            //    nFact = nFact * i;
            //}
            //for (int j = 1; j <= k; j++)
            //{
            //    kFact = kFact * j;
            //}
            //for (int i = 1; i <= k - n; i++)
            //{
            //    nkFact = nkFact * i;
            //}
            //rez = (kFact * nFact) / nkFact;
            Console.WriteLine("The result is {0}", rez);
        }
    }
}
