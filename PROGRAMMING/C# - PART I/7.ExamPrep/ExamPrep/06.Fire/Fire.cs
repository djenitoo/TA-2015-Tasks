using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fire
{
    class Fire
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int leftDots = N / 2 - 1;
            int middleDots = 0;
            for (int i = 0; i < N / 2; i++)
            {
                Console.Write(new string('.',leftDots));
                Console.Write("#");
                Console.Write(new string('.', middleDots));
                Console.Write("#");
                Console.Write(new string('.', leftDots));
                Console.WriteLine();

                leftDots--;
                middleDots = middleDots + 2;
            }
            int downLeftDots = 0;
            int downMiddleDots = N - 2;

            for (int i = N / 2; i > N / 4; i--)
            {
                Console.Write(new string('.', downLeftDots));
                Console.Write("#");
                Console.Write(new string('.', downMiddleDots));
                Console.Write("#");
                Console.Write(new string('.', downLeftDots));
                Console.WriteLine();

                downLeftDots++;
                downMiddleDots = downMiddleDots - 2;
            }
            
            Console.WriteLine(new string('-', N));

            int slash = N / 2;
            for (int i = 0; i < N / 2; i++)
            {
                Console.Write(new string('.', i));
                Console.Write(new string('\\', slash));
                Console.Write(new string('/', slash));
                Console.Write(new string('.', i));
                Console.WriteLine();

                slash--;
            }
        }
    }
}
