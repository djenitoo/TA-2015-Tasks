﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
// Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. Example:
//	N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

namespace _21.Combnations
{
    class Combinations
    {
        static void Main()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Sleep for 2 seconds.");
                Thread.Sleep(2000);
            }

            Console.WriteLine("Main thread exits.");
        }
    }
}
