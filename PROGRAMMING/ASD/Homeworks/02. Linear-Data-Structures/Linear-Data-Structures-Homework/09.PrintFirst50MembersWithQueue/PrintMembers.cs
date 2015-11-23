using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
S1 = N;
S2 = S1 + 1;
S3 = 2*S1 + 1;
S4 = S1 + 2;
S5 = S2 + 1;
S6 = 2*S2 + 1;
S7 = S2 + 2;

Example: N=2 → 2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...
*/
namespace _09.PrintFirst50MembersWithQueue
{
    class PrintMembers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            int len = 50;
            var queue = new Queue<int>();
            queue.Enqueue(n);

            while (i < len)
            {
                int number = queue.Dequeue();
                Console.Write(number + " ");
                i++;

                int first = number + 1;
                queue.Enqueue(first);
                int second = 2*number + 1;
                queue.Enqueue(second);
                int third = number + 2;
                queue.Enqueue(third);
                
            }
            Console.WriteLine();
        }
    }
}
