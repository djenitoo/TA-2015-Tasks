

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Program
{
    static void Main()
    {
        int[] dimentions = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();
        BigInteger moves = BigInteger.Parse(Console.ReadLine());
        BigInteger[,] matrix = new BigInteger[dimentions[0], dimentions[1]];

        CreatingMatrix(dimentions[0], dimentions[1], matrix);

        BigInteger sum = 0;
        BigInteger currentRow = 0;
        BigInteger currentCol = 0;

        for (long i = 0; i < moves; i++)
        {
            string[] directions = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int currentMoves = int.Parse(directions[1]);


            if (directions[0] == "RU" || directions[0] == "UR")
            {
                for (int j = 0; j < currentMoves; j++)
                {
                    sum += matrix[(int)currentRow, (int)currentCol];
                    matrix[(int)currentRow, (int)currentCol] = 0;
                    if (currentCol + 1 > dimentions[1] - 1 || currentRow + 1 > dimentions[0] - 1)
                    {
                        break;
                    }
                    if (i > 0)
                    {
                        if (currentMoves == 1)
                        {
                            break;
                        }
                        currentRow++;
                        currentCol++;
                    }
                    else
                        if (j + 1 != currentMoves)
                        {
                            currentRow++;
                            currentCol++;
                        }
                }
            }
            else
                if (directions[0] == "LU" || directions[0] == "UL")
                {
                    for (int j = 0; j < currentMoves; j++)
                    {
                        if (currentCol - 1 < 0 || currentRow + 1 > dimentions[0] - 1)
                        {
                            break;
                        }
                        if (currentMoves == 1)
                        {
                            break;
                        }
                        currentRow++;
                        currentCol--;
                        sum += matrix[(int)currentRow, (int)currentCol];
                        matrix[(int)currentRow, (int)currentCol] = 0;
                    }
                }
                else
                    if (directions[0] == "DL" || directions[0] == "LD")
                    {
                        for (int j = 0; j < currentMoves; j++)
                        {
                            if (currentMoves == 1)
                            {
                                break;
                            }
                            if (currentCol - 1 < 0 || currentRow - 1 < 0)
                            {
                                break;
                            }
                            currentRow--;
                            currentCol--;
                            sum += (int)matrix[(int)currentRow, (int)currentCol];
                            matrix[(int)currentRow, (int)currentCol] = 0;
                        }
                    }
                    else
                        if (directions[0] == "DR" || directions[0] == "RD")
                        {
                            for (int j = 0; j < currentMoves; j++)
                            {
                                if (currentMoves == 1)
                                {
                                    break;
                                }
                                if (currentCol + 1 > dimentions[1] - 1 || currentRow - 1 < 0)
                                {
                                    break;
                                }
                                currentRow--;
                                currentCol++;
                                sum += matrix[(int)currentRow, (int)currentCol];
                                matrix[(int)currentRow, (int)currentCol] = 0;
                            }
                        }
        }

        Console.WriteLine(sum);
    }

    private static void CreatingMatrix(int rows, int cols, BigInteger[,] matrix)
    {
        BigInteger addThree = rows * 3 - 3;
        BigInteger contenance = 0;
        for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
        {
            contenance = addThree;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = (int)contenance;
                contenance += 3;
            }
            addThree -= 3;
        }
    }
}



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Numerics;

//namespace _03.KaspichanNumbers
//{
//    class KaspichanNumbers
//    {
//        static void Main()
//        {
//            string[] lowerCase = new string[10];
//            string[] upperCase = new string[26];

//            lowerCase[0] = string.Empty;

//            for (int i = 1; i < 10; i++)
//            {
//                lowerCase[i] = ((char)(i + 96)).ToString();
//            }

//            for (int i = 0; i < upperCase.Length; i++)
//            {
//                upperCase[i] = ((char)(i + 65)).ToString();
//            }

//            BigInteger N = BigInteger.Parse(Console.ReadLine());
//            StringBuilder result = new StringBuilder();
//            if (N == 0)
//            {
//                Console.WriteLine("A");
//            }
//            while (N > 0)
//            {
//                int remainer = (int)(N % 256);
//                if (remainer > 25)
//                {
//                    result.Insert(0, upperCase[remainer % 26]);
//                    result.Insert(0, lowerCase[remainer / 26]);
//                }
//                if (remainer <= 25)
//                {
//                    result.Insert(0, upperCase[remainer]);
//                }
//                N /= 256;
//            }
//            Console.WriteLine(result);
//        }
//    }
//}
