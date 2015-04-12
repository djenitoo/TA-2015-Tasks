using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*ha 	fifi 	ho 	hi
fo 	ha 	hi 	xx
xxx 	ho 	ha 	xx
 * 
 */
namespace _03.Matrix_of_Strings
{
    class LongestSequence
    {
        static void Main(string[] args)
        {
            // Input N, M, declarin the matrix and the variables
            //Console.Write("Rows N= ");
            //int N = int.Parse(Console.ReadLine());
            //Console.Write("Colums M= ");
            //int M = int.Parse(Console.ReadLine());
            int N = 3;
            int M = 4;
            string[,] matrix = {{"ha", "fifi", "ho", "hi"},
                               {"fo", "ha", "hi", "xx"},
                               {"xxx", "ho", "ha", "xx"} };
            //string[,] matrix = new string[N, M];
            int sequence = 1;
            int bestSeq = 0;
            int bestRow = 0;
            int bestCol = 0;

            //// Read the matrix from the console
            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        Console.WriteLine("matrix[{0},{1}] = ", row, col);
            //        matrix[row, col] = Console.ReadLine();
            //    }
            //}

            // The solution
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < M; col++)
                {
                    #region Row
                    int x = row;
                    int y = col + 1;
                    while ((((x >= 0) && (x < N)) && ((y >= 0) && (y < M))) && (matrix[row, col] == matrix[x, y]))
                    {
                        sequence++;
                        y++;
                        if (sequence > bestSeq)
                        {
                            bestSeq = sequence;
                            bestRow = row;
                            bestCol = col;
                        }
                    } 
                    #endregion

                    #region Column
                    x = row + 1;
                    y = col;
                    sequence = 1;
                    while ((((x >= 0) && (x < N)) && ((y >= 0) && (y < M))) && (matrix[row, col] == matrix[x, y]))
                    {
                        sequence++;
                        x++;
                        if (sequence > bestSeq)
                        {
                            bestSeq = sequence;
                            bestRow = row;
                            bestCol = col;
                        }
                    } 
                    #endregion

                    #region Diagonal to right
                    x = row;
                    y = col;
                    sequence = 1;
                    if ((x + 1 < N) && (y + 1 < M))
                    {
                        while ((((x >= 0) && (x < N)) && ((y >= 0) && (y < M))) && (matrix[row, col] == matrix[x + 1, y + 1]))
                        {
                            sequence++;
                            x++;
                            y++;
                            if (sequence > bestSeq)
                            {
                                bestSeq = sequence;
                                bestRow = row;
                                bestCol = col;
                            }
                            if (x + 1 >= N || y + 1 >= M)
                            {
                                break;
                            }
                        }
                    } 
                    #endregion

                    #region Diagonal to left
                    x = row;
                    y = col;
                    sequence = 1;
                    while ((((x > 0) && (x < N - 1)) && ((y > 0) && (y < M - 1))) && (matrix[row, col] == matrix[x - 1, y - 1]))
                    {
                        sequence++;

                        if (sequence > bestSeq)
                        {
                            bestSeq = sequence;
                            bestRow = row;
                            bestCol = col;
                        }
                        x--;
                        y--;
                    } 
                    #endregion

                }
            }

            // Output the result
            for (int i = 1; i <= bestSeq; i++)
            {
                Console.Write(matrix[bestRow, bestCol] + " ");
            }
            Console.WriteLine();
        }
    }
}
