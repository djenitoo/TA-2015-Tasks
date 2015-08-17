using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32.ExcelColumns
{
    class ExcelColumns
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            ulong result = 0;

            for (int i = N; i > 0; i--)
            {
                char letter = char.Parse(Console.ReadLine());
                if (i == 1)
                {
                    result += ((ulong)letter - 64);
                }
                else
                {
                    result += (ulong)Math.Pow(26, i - 1) * ((ulong)letter - 64);
                }
            }
            Console.WriteLine(result);
        }
    }
}
