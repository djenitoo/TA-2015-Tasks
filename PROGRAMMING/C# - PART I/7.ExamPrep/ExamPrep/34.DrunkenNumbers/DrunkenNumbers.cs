using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34.DrunkenNumbers
{
    class DrunkenNumbers
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int drinksM = 0;
            int drinksV = 0;

            for (int i = 0; i < N; i++)
            {
                long number = long.Parse(Console.ReadLine());
                if (number < 0)
                {
                    number *= -1;
                }
                string str = number.ToString();
                if (str.Length % 2 != 0)
                {
                    for (int p = 0, j = str.Length - 1; p <= str.Length / 2; p++, j--)
                    {
                        drinksM += Convert.ToInt32(str[p]) - (int)'0';
                        drinksV += Convert.ToInt32(str[j]) - (int)'0';
                    }
                }
                else
                {
                    for (int p = 0, j = str.Length - 1; p < str.Length / 2; p++, j--)
                    {
                        drinksM += Convert.ToInt32(str[p]) - (int)'0';
                        drinksV += Convert.ToInt32(str[j]) - (int)'0';
                    }
                }
            }

            if (drinksM > drinksV)
            {
                Console.WriteLine("M " + (drinksM - drinksV));
            }
            else if (drinksV > drinksM)
            {
                Console.WriteLine("V " + (drinksV - drinksM));
            }
            else
            {
                Console.WriteLine("No "+ (drinksM + drinksV));
            }
        }
    }
}
