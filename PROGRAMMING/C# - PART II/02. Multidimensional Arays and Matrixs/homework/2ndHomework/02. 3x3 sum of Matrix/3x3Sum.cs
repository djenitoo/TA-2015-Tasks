using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Write a program that reads a rectangular matrix of 
 * size N x M and finds in it the square 3 x 3 that 
 * has maximal sum of its elements.
 */
namespace _02._3x3_sum_of_Matrix
{
    class Program
    {
        static void Main()
        {
            //Console.Write("Rows N= ");
            //int N = int.Parse(Console.ReadLine());
            //Console.Write("Colums M= ");
            //int M = int.Parse(Console.ReadLine());
            int[,] matrix = { 
                            { 3, 2, 1, 5, 6, 2, 0 }, 
                            { 3, 2, 1, 4, 2, 5, 7 }, 
                            { 4, 6, 3, 2, 1, 10, 4 },
                            { 9, 3, 1, 5, 1, 1, 11 } };
            //int[,] matrix = new int[N,M];

            //// Read the matrix
            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        Console.WriteLine("matrix[{0},{1}] = ", row, col);
            //        matrix[row, col] = int.Parse(Console.ReadLine());
            //    }
            //}
            int bestSum = 0;
            int bestRow = 0;
            int bestCol = 0;

            // Searching the matrix

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (sum > bestSum)
                    {
                        bestRow = row;
                        bestCol = col;
                        bestSum = sum;
                    }
                }
            }

            // Printing the biggest sum area

            for (int row = bestRow; row < bestRow + 3; row++)
            {
                for (int col = bestCol; col < bestCol + 3; col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
