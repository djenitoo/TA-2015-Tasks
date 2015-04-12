using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SpecialValue
{
    class SpecialValue
    {
        static int N;
        static int[][] array;
        static int currSV = 0;
        static int specValue = int.MinValue;
        static int path = 0;

        static void Main()
        {
            N = int.Parse(Console.ReadLine());
            array = new int[N][];
            for (int i = 0; i < N; i++)
            {
                string str = Console.ReadLine();
                string[] Str = str.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                array[i] = Str.Select(strNum => (int.Parse(strNum))).ToArray();
            }
            for (int col = 0; col < array[0].Length; col++)
            {
                int currentSpecVal = CountPaths(0, col);
                specValue = Math.Max(specValue, currentSpecVal);
            }
            Console.WriteLine(specValue);
        }

        static int CountPaths(int row, int index)
        {
            path++;
            int currNum = array[row][index];
            if (array[row][index] < 0)
            {
                currSV = path + (Math.Abs(currNum));
                path = 0;
                return currSV;
            }
            else
        	{
                index = currNum;
                row = (row == N - 1) ? 0 : row + 1;

                CountPaths(row, index);
        	}
            return currSV;
        }
    }
}
