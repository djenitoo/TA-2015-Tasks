using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.BinaryDigitsCount
{
    class BinaryDigitsCount
    {
        static void Main(string[] args)
        {
            int B = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            uint[] numbers = new uint[N];
            uint[] answers = new uint[N];
            uint count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = uint.Parse(Console.ReadLine());

                while (numbers[i] != 0)
                {
                    if (B == 0)
                    {
                        uint temp = numbers[i] & 1;
                        if (temp == 0)
                        {
                            count++;
                        }
                    }
                    else
                    {
                        count += numbers[i] & 1;
                    }
                    numbers[i] >>= 1;
                }

                answers[i] = count;
                count = 0;
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(answers[i]);
            }
        }
    }
}
