using System;

namespace _11.BatGoikoTower
{
    class BatGoiko
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int outDots = n - 1;
            int middle = 0;
            int k = 2;
            int h = 2;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('.', outDots));
                Console.Write("/");
                if (i % k == 0)
                {
                    Console.Write(new string('-', middle));
                    k += h;
                    h++;
                    
                }
                else
                {
                    Console.Write(new string('.', middle));
                }
                Console.Write("\\");
                Console.Write(new string('.', outDots));

                middle += 2;
                outDots--;
                Console.WriteLine();
            }
        }
    }
}
