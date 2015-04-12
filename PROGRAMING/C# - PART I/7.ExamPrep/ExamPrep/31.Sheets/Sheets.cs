using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31.Sheets
{
    class Sheets
    {
        static void Main(string[] args)
        {
            int[] lists = new int[11];
            int N = int.Parse(Console.ReadLine());
            for (int i = 10, j = 0; i >= 0; i--, j++)
            {
                if ((int)Math.Pow(2, i) <= N)
                {
                    lists[j] = 1;
                    N -= (int)Math.Pow(2, i);
                }
            }
            for (int i = 10; i >= 0; i--)
            {
                if (lists[i] != 1)
                {
                    Console.WriteLine("A" + i);
                }
            }

        }
    }
}
