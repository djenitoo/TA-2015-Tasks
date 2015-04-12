using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40.OnesAndZeros
{
    class OnesAndZeros
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            string str = Convert.ToString(N, 2).PadLeft(16, '0');
            
            string zero1 = "###";
            string zero5 = zero1;
            string zero2 = "#.#";
            string zero3 = zero2;
            string zero4 = zero2;

            string one1 = ".#.";
            string one2 = "##.";
            string one3 = ".#.";
            string one4 = one3;
            string one5 = zero1;

            for (int i = 1; i <= 5; i++)
            {
                string printZero = "";
                string printOne = "";
                if (i == 1)
                {
                    printOne = one1;
                    printZero = zero1;
                }
                else if (i == 2)
                {
                    printZero = zero2;
                    printOne = one2;
                }
                else if (i == 3)
                {
                    printOne = one3;
                    printZero = zero3;
                }
                else if (i == 4)
                {
                    printOne = one4;
                    printZero = zero4;
                }
                else
                {
                    printZero = zero5;
                    printOne = one5;
                }

                for (int j = 0, p = str.Length - 16; j < 16; j++, p++)
                {
                    //ulong temp = N;

                    if (str[p] == '0')
                    {
                        Console.Write(printZero);
                    }
                    else
                    {
                        Console.Write(printOne);
                    }
                    if (j != 15)
                    {
                        Console.Write(".");
                    }
                    //temp >>= 1;
                }
                Console.WriteLine();
            }
        }
    }
}
