using System;

namespace _13.Trapezoid
{
    class Trapezoid
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n;
            int height = n + 1;

            Console.Write(new string('.', width / 2));
            Console.Write(new string('*', width / 2));
            Console.WriteLine();

            int leftDots = width / 2 - 1;
            int rightDots = 0;
            for (int i = 2; i <= n; i++)
            {
                Console.Write(new string('.', leftDots));
                Console.Write("*");
                Console.Write(new string('.', rightDots));
                Console.Write(new string('.', n -1));
                Console.Write("*");

                leftDots--;
                rightDots++;
                Console.WriteLine();
            }
            Console.Write(new string('*', width));
            Console.WriteLine();
        }
    }
}
