using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.WeAllLoveBits_
{
    class WeAllLoveBits
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];

            for (int i = 0; i < N; i++)
            {
                int reverse = 0;
                string change = "";
                int number = int.Parse(Console.ReadLine());
                int p = number;
                //TODO: maybe here method for compiling? :D
                /*
                 * REVERSE: OUT<<1 + out|(NUMBER & 1); SHIFT >> NUMBER
                   CHANGE: OUT2<< 1 + NUMBER & 1; IF 0-> OUT2^1; SHIFT >> NUMBER
                 * */
                for (; number != 0; number >>= 1)
                {
                    reverse <<= 1;
                    int temp = (number & 1);
                    reverse |= temp;
                    if (temp == 0)
                    {
                        change = "1" + change;

                    }
                    else
                    {
                        change = "0" + change;
                    }
                }
                int ch = Convert.ToInt32(change, 2);
                arr[i] = (p ^ ch) & reverse;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
