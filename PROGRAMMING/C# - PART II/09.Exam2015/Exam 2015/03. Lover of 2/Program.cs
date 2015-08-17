using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _03.Lover_of_2
{
    class Program
    {
        static int R;
        static int C;
        static BigInteger[,] matrix;
        static bool[,] isVisited;
        static BigInteger points = 0;

        static void Main(string[] args)
        {
            R = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());

            FillMatrix();
            isVisited = new bool[R, C];

            int N = int.Parse(Console.ReadLine());

            string[] str = Console.ReadLine().Split(' ');
            int[] directions = Array.ConvertAll(str, int.Parse);
            
            int coef = Math.Max(R, C);
            int row = R - 1;
            int col = 0;
            points += matrix[row, col];
            isVisited[row, col] = true;
            for (int i = 0; i < directions.Length; i++)
            {

                // next Dvijenie/mqsto
                int lastRow = row;
                int lastCol = col;
                row = directions[i] / coef;
                CollectPoints(lastRow, lastCol, row, col);
                lastRow = row;
                col = directions[i] % coef;
                CollectPoints(lastRow, lastCol, row, col);
                // sabirane na tochki
                
            }
            Console.WriteLine(points);

        }

        private static void CollectPoints(int lastRow, int lastCol, int row, int col)
        {
            int dir = 0;
            if (lastRow != row)
            {
                if (lastRow < row)
                {
                    while (lastRow <= row)
                    {
                        if (!isVisited[lastRow, lastCol])
                        {
                            points += matrix[lastRow, lastCol];
                            isVisited[lastRow, lastCol] = true;
                        }
                        lastRow++;

                    }
                }
                else
                {
                    dir = 1;
                    while (lastRow >= row)
                    {
                        if (!isVisited[lastRow, lastCol])
                        {
                            points += matrix[lastRow, lastCol];
                            isVisited[lastRow, lastCol] = true;
                        }
                        lastRow--;

                    }
                }
            }
            else
            {
                if (lastCol < col)
                {
                    dir = 2;
                    while (lastCol <= col)
                    {
                        if (!isVisited[lastRow, lastCol])
                        {
                            points += matrix[lastRow, lastCol];
                            isVisited[lastRow, lastCol] = true;
                        }
                        lastCol++;
                    }
                }
                else
                {
                    dir = 4;
                    while (lastCol >= col)
                    {
                        if (!isVisited[lastRow, lastCol])
                        {
                            points += matrix[lastRow, lastCol];
                            isVisited[lastRow, lastCol] = true;
                        }
                        lastCol--;
                    }
                }
            }

        }

        static void MatrixPrint(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void FillMatrix()
        {
            matrix = new BigInteger[R, C];

            int count = R * C;
            int row = R;
            int col = 0;
            BigInteger nexBegin = 1;
            
            for (int i = R - 1; i >= 0; i--)
            {
                for (int j = 0; j < C; j++)
                {
                    
                    matrix[i, j] = nexBegin;
                    nexBegin *= 2;
                }
                nexBegin = matrix[i,1];
            }
        }
    }
}
