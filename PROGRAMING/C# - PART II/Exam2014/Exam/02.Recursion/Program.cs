using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.TwoGirlsOnePath
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] strSplit = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            long[] arr = strSplit.Select(str => (long.Parse(str))).ToArray();

            Method(arr);
        }

        static void Method(long[] arr)
        {
            BigInteger Molly = 0;
            long Dolly = 0;
            long M = 0;
            long D = arr.Length - 1;
            string winner = string.Empty;
            while (arr[M] == 0 || arr[D] == 0)
            {

                if ((arr[M] != 0) && (arr[D] != 0))
                {
                    if (M == D)
                    {
                        Molly = Molly + arr[M] / 2;
                        Dolly = Dolly + arr[D] / 2;
                        M += arr[M];
                        D -= arr[D];
                    }
                    else
                    {
                        Molly = Molly + arr[M];
                        Dolly = Dolly + arr[D];
                        long temp1 = arr[M];
                        long temp2 = arr[D];
                        arr[M] = 0;
                        arr[D] = 0;
                        M += temp1;
                        D -= temp2;
                    }
                }
                //else if (arr[M] == 0 || arr[D] == 0)
                //{
                //    Molly = Molly + arr[M];
                //    Dolly = Dolly + arr[D];
                //    if ((arr[M] == 0) && (arr[D] == 0))
                //    {
                //        winner = "Draw";
                //    }
                //    else if (arr[M] == 0)
                //    {
                //        winner = "Dolly";
                //    }
                //    else
                //    {
                //        winner = "Molly";
                //    }
                //    break;
                //}
                while (M > arr.Length - 1)
                {
                    M = M % arr.Length;
                }
                while (D < 0)
                {
                    D = D + arr.Length;
                }
            }
            Molly = Molly + arr[M];
            Dolly = Dolly + arr[D];
            if ((arr[M] == 0) && (arr[D] == 0))
            {
                winner = "Draw";
            }
            else if (arr[M] == 0)
            {
                winner = "Dolly";
            }
            else
            {
                winner = "Molly";
            }
            Console.WriteLine(winner);
            Console.WriteLine(Molly + " " + Dolly);
        }
    }
}
