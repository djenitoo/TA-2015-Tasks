using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.MissCat
{
    class MissCat2011
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] conts = new int[11];

            for (int i = 0; i < N; i++)
            {
                int cont = int.Parse(Console.ReadLine());
                conts[cont]++;
            }
            int maxVal = conts.Max();

            for (int i = 0; i < conts.Length; i++)
            {
                if (conts[i] == maxVal)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
