using System;

namespace _02.Tubes
{
    class tubes
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());

            uint[] tubesSize = new uint[N];
            uint maxTube = 0;
            for (int i = 0; i < N; i++)
            {
                tubesSize[i] = uint.Parse(Console.ReadLine());
                if (maxTube < tubesSize[i])
                {
                    maxTube = tubesSize[i];
                }
            }

            uint left = 1;
            uint right = maxTube;
            uint middle = (left + right) / 2;
            long res = -1;
            while (left <= right)
            {
                uint countOfTubes = 0;

                for (int i = 0; i < N; i++)
                {
                    countOfTubes += tubesSize[i] / middle;
                }

                if (countOfTubes < M)
                {
                    right = middle - 1;
                }
                else if (countOfTubes >= M)
                {
                    left = middle + 1;
                    res = middle;
                }
                middle = (left + right) / 2;
            }

            Console.WriteLine(res);
            //for (uint i = maxTube; i >= 1; i--)
            //{
            //    uint countOfTubes = 0;

            //    for (int j = 0; j < N; j++)
            //    {
            //        countOfTubes += tubesSize[j] / i;
            //    }
            //    if (countOfTubes >= M)
            //    {
            //        Console.WriteLine(i);
            //        break;
            //    }
            //}

        }
    }
}
