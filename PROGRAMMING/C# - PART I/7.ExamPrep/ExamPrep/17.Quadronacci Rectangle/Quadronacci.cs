using System;

namespace _17.Quadronacci_Rectangle
{
    class Quadronacci
    {
        static void Main()
        {
            long elOne = long.Parse(Console.ReadLine());
            long elTwo = long.Parse(Console.ReadLine());
            long elThree = long.Parse(Console.ReadLine());
            long elFour = long.Parse(Console.ReadLine());
            long rows = long.Parse(Console.ReadLine());
            long columns = long.Parse(Console.ReadLine());

            if ((rows == 1) && (columns == 4))
            {
                Console.WriteLine(elOne + " " + elTwo + " " + elThree + " " + elFour);
            }
            else
            {
                long[] arr = new long[rows * columns];
                arr[0] = elOne;
                arr[1] = elTwo;
                arr[2] = elThree;
                arr[3] = elFour;
                for (int i = 4; i < arr.Length; i++)
                {
                    arr[i] = arr[i - 1] + arr[i - 2] + arr[i - 3] + arr[i - 4];
                }
                long index = 0;
                for (long i = 1; i <= rows; i++ )
                {
                    long elNumb = 1;
                    while (elNumb <= columns)
                    {
                        for (long j = 1; j <= columns * 2; j++)
                        {
                            if (j % 2 != 0)
                            {
                                Console.Write(arr[index]);
                                index++;
                                elNumb++;
                            }
                            else
                            {
                                Console.Write(" ");
                                elNumb++;
                            }
                        }
                        
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
