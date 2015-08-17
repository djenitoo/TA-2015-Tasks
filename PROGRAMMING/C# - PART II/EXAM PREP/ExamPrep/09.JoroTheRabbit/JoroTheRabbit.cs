using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.JoroTheRabbit
{
    class JoroTheRabbit
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] terrainStr = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] terrain = terrainStr.Select(strNum => (int.Parse(strNum))).ToArray();

            long bestPoints = long.MinValue;

            for (int step = 1; step <= terrain.Length; step++)
            {
                for (int startPos = 0; startPos < terrain.Length; startPos++)
                {
                    int pos = startPos;
                    long point = 0;
                    int lastPos = startPos;
                    while ((terrain[pos] > terrain[lastPos]) || point == 0)
                    {
                        point += 1;
                        lastPos = pos;
                        pos += step;
                        if (pos > terrain.Length - 1)
                        {
                            pos %= terrain.Length;
                        }
                    }
                    if (bestPoints < point)
                    {
                        bestPoints = point;
                    }
                }
            }

            Console.WriteLine(bestPoints);
        }
    }
}
