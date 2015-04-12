using System;

namespace _04.Kaspichania_Boats
{
    class KanspichanianBoats
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int width = (2 * N) + 1;
            int height = 6 + ((N - 3) / 2) * 3;

            Console.Write(new string('.', N));
            Console.Write("*");
            Console.Write(new string('.', N));
            Console.WriteLine();

            int outerDots = N - 1;
            int innerDots = 0;
            for (int i = 2; i <= N; i++)
            {
                Console.Write(new string('.', outerDots));
                Console.Write("*");
                Console.Write(new string('.', innerDots));
                Console.Write("*");
                Console.Write(new string('.', innerDots));
                Console.Write("*");
                Console.Write(new string('.', outerDots));
                Console.WriteLine();
                outerDots--;
                innerDots++;
            }

            Console.WriteLine(new string('*', width));

            int leftDots = 1;
            int middleDots = N - 2;

            for (int i = 1; i < (N + 1) / 2; i++)
            {
                Console.Write(new string('.', leftDots));
                Console.Write("*");
                Console.Write(new string('.', middleDots));
                Console.Write("*");
                Console.Write(new string('.', middleDots));
                Console.Write("*");
                Console.Write(new string('.', leftDots));
                Console.WriteLine();
                leftDots++;
                middleDots--;
            }

            Console.Write(new string('.', (N + 1) / 2));
            Console.Write(new string('*', N));
            Console.Write(new string('.', (N + 1) / 2));
            Console.WriteLine();
        }
    }
}
