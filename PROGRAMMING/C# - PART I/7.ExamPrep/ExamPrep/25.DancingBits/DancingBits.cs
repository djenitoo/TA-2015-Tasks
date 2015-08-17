using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.DancingBits
{
    class DancingBits
    {
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            string result = "";
            int output = 0;

            for (int i = 0; i < N; i++)
            {
                int number = int.Parse(Console.ReadLine());
                result += Convert.ToString(number, 2);
            }

            int previousBit = result[0];
            int count = 1;

            for (int i = 1; i < result.Length; i++)
            {
                if (result[i] == previousBit)
                {
                    count++;
                }
                else
                {
                    if (count == K)
                    {
                        output++;
                    }
                    count = 1;
                    previousBit = result[i];
                }
            }
            if (count == K)
            {
                output++;
            }

            Console.WriteLine(output);
        }
    }
}
