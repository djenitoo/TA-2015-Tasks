using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. Example:
//	N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

namespace _20.Variations_of_K_and_N         // Crazy one, won't work properly. =.=
{
    class Variations
    {
        static void Main()
        {
            Console.Write("Enter N: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            int K = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 3; i++)
            {
                int miniRows = 1;
                while (miniRows <= N)
                {
                    int elOnRow = 1;
                    Console.WriteLine(i + " ");
                    int j = 1;
                    while (elOnRow < K)
                    {
                        Console.Write(j + " ");
                        j++;
                    }
                    Console.WriteLine();
                }
                
            }
        }
    }
}
