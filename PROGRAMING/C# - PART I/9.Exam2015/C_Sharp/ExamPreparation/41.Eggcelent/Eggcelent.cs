using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41.Eggcelent
{
    class Eggcelent
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int width = 3 * N + 1;
            int widthEgg = 3 * N - 1;
            int height = 2 * N;
            int leftDots = (width - (N - 2)) / 2;
            int rightDots = leftDots;
            int middleDots = (N - 1);
            string ends = new string('.', leftDots) + new string('*', N - 1) + new string('.', rightDots);
            int count = 0;
            //----------------------------------------------
            Console.WriteLine(ends);

            if (N - 1 != 1)
            {
                for (int i = 2; i < N; i++)
                {
                    leftDots -= 2;
                    rightDots -= 2;
                    middleDots = width - (leftDots + rightDots + 2);
                    if (leftDots <= 0)
                    {
                        leftDots = 1;
                        rightDots = 1;
                        middleDots = width - 4;
                        count++;
                    }
                    string print = new string('.', leftDots) + "*" + new string('.', middleDots) + "*" + new string('.', rightDots);
                    Console.WriteLine(print);

                    
                }
            }
            // -------------------------
            string upperCrack = "";
            string downCrack = "";

            if (N == 2)
            {
                middleDots += 2;
            }
            for (int i = 1; i <= middleDots; i++)
            {
                if (i % 2 != 0)
                {
                    upperCrack += "@";
                    downCrack += ".";
                }
                else
                {
                    upperCrack += ".";
                    downCrack += "@";
                }
            }
            upperCrack = ".*" + upperCrack + "*.";
            downCrack = ".*" + downCrack + "*.";

            Console.WriteLine(upperCrack);
            Console.WriteLine(downCrack);

            // ---------------------
            if (N - 1 != 1)
            {
                for (int i = 2; i < N; i++)
                {
                    
                    string print = new string('.', leftDots) + "*" + new string('.', middleDots) + "*" + new string('.', rightDots);
                    Console.WriteLine(print);
                    leftDots += 2;
                    rightDots += 2;
                    middleDots = width - (leftDots + rightDots + 2);
                    if (count > 0)
                    {
                        leftDots = 1;
                        rightDots = 1;
                        middleDots = width - 4;
                        count--;
                    }
                }
            }

            Console.WriteLine(ends);
        }
    }
}
