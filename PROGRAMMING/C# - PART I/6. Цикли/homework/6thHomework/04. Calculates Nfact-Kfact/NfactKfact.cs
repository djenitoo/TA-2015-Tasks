using System;
// Write a program that calculates N!/K! for given N and K (1<K<N).

namespace _04.Calculates_Nfact_Kfact
{
    class NfactKfact
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter k:");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter n [n>k]:");
            int n = int.Parse(Console.ReadLine());
            int up = 1;
            int down = 1;
            double rez = 0;
            for (int i = 1; i <= n; i++)
            {
                up = up * i;
            }
            for (int j = 1; j <= k; j++)
            {
                down = down * j;
            }
            rez = up / down;
            Console.WriteLine("The result is {0}", rez);
        }
    }
}
