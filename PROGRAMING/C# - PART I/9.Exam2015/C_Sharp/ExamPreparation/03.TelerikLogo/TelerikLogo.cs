using System;

namespace _03.TelerikLogo
{
    class TelerikLogo
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int Y = X;
            int Z = (X / 2) + 1;

            int width = (2 * Y) + (2 * Z) - 3;
            int border = X / 2;

            int firstHorn = border - 1;
            int secondHorns = 0;

            // top
            int upMiddleDots = 2 * Y - 3;
            Console.Write(new string('.', border));
            Console.Write("*");
            Console.Write(new string('.', upMiddleDots));
            Console.Write("*");
            Console.Write(new string('.', border));
            Console.WriteLine();

            // up-top Y

            // middle
            for (int i = 1; i <= X - 2; i++)
            {
                upMiddleDots -= 2;
                if (i <= X / 2)
                {
                    Console.Write(new string('.', firstHorn));
                    Console.Write("*");
                    Console.Write(new string('.', secondHorns));
                }
                else
                {
                    Console.Write(new string('.', border));
                }

                Console.Write(new string('.', i));
                Console.Write("*");
                Console.Write(new string('.', upMiddleDots));
                Console.Write("*");
                Console.Write(new string('.', i));

                if (i <= X / 2)
                {
                    Console.Write(new string('.', secondHorns));
                    Console.Write("*");
                    Console.Write(new string('.', firstHorn));
                    firstHorn = firstHorn - 1;
                    secondHorns = secondHorns + 1;
                }
                else
                {
                    Console.Write(new string('.', border));
                }
                Console.WriteLine();
            }

            // middle row

            Console.Write(new string('.', width / 2));
            Console.Write("*");
            Console.Write(new string('.', width / 2));
            Console.WriteLine();

            // first X part
            int middleDots = 1;

            for (int i = (width - 2 * Z) / 2; i >= 0; i--)
            {
                Console.Write(new string('.', border));
                Console.Write(new string('.', i));
                Console.Write("*");
                Console.Write(new string('.', middleDots));
                Console.Write("*");
                Console.Write(new string('.', i));
                Console.Write(new string('.', border));
                Console.WriteLine();
                middleDots += 2;
            }

            // second X part
            int downMiddleDots = (width - 2 * Z) - 2;

            for (int i = 1; i <= X - 2; i++)
            {
                
                Console.Write(new string('.', border));
                Console.Write(new string('.', i));
                Console.Write("*");
                Console.Write(new string('.', downMiddleDots));
                Console.Write("*");
                Console.Write(new string('.', i));
                Console.Write(new string('.', border));
                Console.WriteLine();
                downMiddleDots -= 2;
            }

            // Bottom

            Console.Write(new string('.', width / 2));
            Console.Write("*");
            Console.Write(new string('.', width / 2));
            Console.WriteLine();
        }
    }
}
