using System;
using System.Collections.Generic;

/*
N = N+1
N = N+2

N = N*2
    */
namespace _10.ShortestSequenceOperations
{
    class ShortestSequenceOperations
    {
        static void Main()
        {
            int n = 5;
            int m = 16;
            var queue = new Queue<int>();
            //queue.Enqueue(m);

            while (n <= m)
            {
                queue.Enqueue(m);

                if (m / 2 >= n)
                {
                    if (m % 2 == 0)
                    {
                        m /= 2;
                    }
                    else
                    {
                        m--;
                    }
                    
                }
                else
                {
                    if (m - 2 >= n)
                    {
                        m -= 2;
                    }
                    else
                    {
                        m--;
                    }
                }

                
            }

            Console.WriteLine(string.Join(", ", queue));
        }
    }
}
