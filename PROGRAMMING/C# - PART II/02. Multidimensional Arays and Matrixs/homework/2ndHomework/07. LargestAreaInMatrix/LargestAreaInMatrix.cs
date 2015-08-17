using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LargestAreaInMatrix
{
    class LargestAreaInMatrix
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 1, 3, 2, 2, 2, 4 },
                              { 3, 3, 3, 2, 4, 4 },
                              { 4, 3, 1, 2, 3, 3 },
                              { 4, 3, 1, 3, 3, 1 },
                              { 4, 3, 3, 3, 1, 1 } };

            int count = Algo(matrix);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(string.Join(", ", matrix[i, j]));
                }
                Console.WriteLine();
            }
            Console.WriteLine("Count of the biggest arrea: " + count);
        }

        private static int Algo(int[,] matrix)
        {
            int bestCount = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    bool[,] check = new bool[matrix.GetLength(0), matrix.GetLength(1)];
                    int tempCount = DFS(matrix, check, i, j);
                    if (tempCount > bestCount)
                    {
                        bestCount = tempCount;
                    }
                }
            }

            return bestCount;
        }

        private static int DFS(int[,] matrix, bool[,] check, int row, int col)
        {
            int count = 0;
            int x = row;
            int y = col;
            if (!check[row,col])
            {
                check[row, col] = true;
                count++;
                //up
                if (row - 1 >= 0 && check[row - 1, col] == false && matrix[row, col] == matrix[row - 1, col])
                {
                    count += DFS(matrix, check, x - 1, y);
                }
                //right
                if (col + 1 < matrix.GetLength(1) && check[row, col + 1] == false && matrix[row, col] == matrix[row, col + 1])
                {
                    count += DFS(matrix, check, x, y + 1);
                }
                //down
                if (row + 1 < matrix.GetLength(0) && check[row + 1, col] == false && matrix[row, col] == matrix[row + 1, col])
                {
                    count += DFS(matrix, check, x + 1, y);
                }
                //left
                if (col - 1 >= 0 && check[row, col - 1] == false && matrix[row, col] == matrix[row, col - 1])
                {
                    count += DFS(matrix, check, x, y - 1);
                }
            }

            return count;
        }
    }
}
