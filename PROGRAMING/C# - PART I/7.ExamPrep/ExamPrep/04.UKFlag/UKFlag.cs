using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.UKFlag
{
    class UKFlag
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftDots = 0;
            int rightDots = n / 2 - 1;
            int leftDots1 = 0;
            int rightDots1 = n / 2 - 1;

            // first part
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('.', leftDots));
                Console.Write("\\");
                Console.Write(new string('.', rightDots));
                Console.Write("|");
                Console.Write(new string('.', rightDots));
                Console.Write("/");
                Console.Write(new string('.', leftDots));
                Console.WriteLine();
                leftDots++;
                rightDots--;
            }

            // middle
            Console.Write(new string('-', n / 2));
            Console.Write("*");
            Console.Write(new string('-', n / 2));
            Console.WriteLine();

            // second part
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('.', rightDots1));
                Console.Write("/");
                Console.Write(new string('.', leftDots1));
                Console.Write("|");
                Console.Write(new string('.', leftDots1));
                Console.Write("\\");
                Console.Write(new string('.', rightDots1));
                Console.WriteLine();
                leftDots1++;
                rightDots1--;
            }
        }
    }
}
