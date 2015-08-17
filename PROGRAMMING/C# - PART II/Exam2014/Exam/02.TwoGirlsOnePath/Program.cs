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
            string[] strSplit = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            BigInteger[] arr = strSplit.Select(str => (BigInteger.Parse(str))).ToArray();

            Method(arr);
        }

        static void Method(BigInteger[] arr)
        {
            BigInteger Molly = 0;
            BigInteger Dolly = 0;
            long M = 0;
            long D = arr.Length - 1;
            string winner = string.Empty;
            while (true)
            {
                
                if ((arr[M] != 0) && (arr[D] != 0))
                {
                    if (M == D)
                    {
                        Molly += arr[M] / 2;
                        Dolly += arr[D] / 2;
                        BigInteger temp2 = arr[D];
                        arr[D] -= 2 * (temp2 / 2);
                        M = (int)((M + temp2) % arr.Length);
                        D = (int)((D - temp2) % arr.Length);
                        
                        
                        
                    }
                    else
                    {
                        Molly += arr[M];
                        Dolly += arr[D];
                        BigInteger temp1 = arr[M];
                        BigInteger temp2 = arr[D];
                        arr[M] = 0;
                        arr[D] = 0;
                        M = (int)((M + temp1) % arr.Length);
                        D = (int)((D - temp2) % arr.Length);
                    }
                    //while (M > arr.Length - 1)
                    //{
                    //    M %= arr.Length;
                    //}
                    //while (D < 0)
                    //{
                    //    D = D + arr.Length;
                    //}
                    if (D < 0) D += arr.Length;
                }
                else
                {
                    Molly += arr[M];
                    Dolly += arr[D];
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
                    break;
                }
                
                //while (M > arr.Length - 1 || D < 0)
                //{
                //    
                //    
                //}
               
            }
            Console.WriteLine(winner);
            Console.WriteLine(Molly + " " + Dolly);
        }
    }
}
