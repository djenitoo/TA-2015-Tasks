using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _08.GreedyDwarf
{
    class GreedyDarf
    {
        static List<long> CutDigits(string text)
        {
            string digits = string.Empty;
            List<long> strToNumb = new List<long>();

            for (int i = 0; i < text.Length; i++)
            {
                while (i < text.Length && (text[i] != ','))
                {
                    if (Char.IsDigit(text[i]) || text[i] == '-')
                    {
                        digits += text[i];
                    }
                    i++;
                }
                strToNumb.Add(long.Parse(digits));
                digits = string.Empty;

            }
            return strToNumb;
        }

        static void Main()
        {
            string strValley = Console.ReadLine();
            long M = long.Parse(Console.ReadLine());
            string[] strPatterns = new string[M];

            for (long i = 0; i < M; i++)
            {
                strPatterns[i] = Console.ReadLine();
            }

            List<long> valley = CutDigits(strValley);
            List<List<long>> patterns = new List<List<long>>();
            for (long i = 0; i < M; i++)
            {
                patterns.Add(CutDigits(strPatterns[i]));
            }

            long bestCoins = int.MinValue;
            for (int i = 0; i < M; i++)
            {
                List<long> copyVall = valley.ToList();
                long coins = copyVall[0];
                copyVall[0] = 10001;
                int index = (int)patterns[i][0];
                int j = 0;
                while (((index < copyVall.Count) && (index >= 0)) && (copyVall[index] != 10001))
                {
                    coins += copyVall[index];
                    copyVall[index] = 10001;
                    if (j == patterns[i].Count - 1)
                    {
                        j = 0;
                        index += (int)patterns[i][j];
                    }
                    else if ((j < patterns[i].Count - 1) && (j >= 0))
                    {
                        j++;
                        index += (int)patterns[i][j];
                    }
                }
                if (bestCoins < coins)
                {
                    bestCoins = coins;
                }
            }

            Console.WriteLine(bestCoins);
        }
    }
}
