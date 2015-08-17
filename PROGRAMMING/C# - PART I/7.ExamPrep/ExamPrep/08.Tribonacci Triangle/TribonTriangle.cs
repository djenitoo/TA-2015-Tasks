using System;

namespace _08.Tribonacci_Triangle
{
    class TribonTriangle
    {
        static void Main(string[] args)
        {
            int elOne = int.Parse(Console.ReadLine());
            int elTwo = int.Parse(Console.ReadLine());
            int elThree = int.Parse(Console.ReadLine());
            int row = int.Parse(Console.ReadLine());

            int countOfEl = 0;

            for (int i = 1; i <= row; i++)
            {
                countOfEl += i;
            }

            long[] arr = new long[countOfEl];
            arr[0] = elOne;
            arr[1] = elTwo;
            arr[2] = elThree;

            if (row > 2)
            {
                for (int i = 3; i < countOfEl; i++)
                {
                    arr[i] = arr[i - 1] + arr[i - 2] + arr[i - 3];
                }
                int elOnRow = -1;
                int go = 0;
                for (int i = 1; i <= row; i++)
                {
                    int elNumb = 1;
                    elOnRow += 2;
                    while (elNumb <= elOnRow)
                    {
                        for (int j = 1; j <= elOnRow; j++)
                        {
                            if (j % 2 != 0)
                            {
                                Console.Write(arr[go]);
                                go++;
                                elNumb++;
                            }
                            else
                            {
                                Console.Write(" ");
                                elNumb++;
                            }
                        }
                        
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine(arr[0]);
                Console.WriteLine(arr[1]+" "+arr[2]);
            }

        }
    }
}
