using System;

namespace _12.Forest_Road
{
    class ForestRoad
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int leftDots = 0;
            int rightDots = n - 1;

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('.', leftDots));
                Console.Write("*");
                Console.Write(new string('.', rightDots));

                leftDots++;
                rightDots--;
                Console.WriteLine();

            }
            int left = n - 2;
            int right = 1;
            for (int i = 1; i <= n - 1; i++)
            {
                Console.Write(new string('.', left));
                Console.Write("*");
                Console.Write(new string('.', right));

                right++; ;
                left--;
                Console.WriteLine();

            }


            //Console.WriteLine("Enter path n: ");
            //byte N = byte.Parse(Console.ReadLine());

            //for (int i = 0; i < 2 * N - 1; i++)
            //{
            //    for (int tree = 0; tree <= N - i; tree++)
            //    {
            //        Console.Write(".");
            //    }
            //    Console.Write("*");
            //    for (int tree = i; tree >= 0; tree--)
            //    {
            //        Console.Write(".");
            //    }
            //    Console.WriteLine();

            //}
            //Console.WriteLine();
        }
    }
}
