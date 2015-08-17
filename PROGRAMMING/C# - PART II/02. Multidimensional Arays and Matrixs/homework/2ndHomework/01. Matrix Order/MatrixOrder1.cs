using System;

namespace _01.Matrix_Order
{   //Sorry for the many comments, if you made the problem you can skip them
    
    class MatrixOrder1
    {
        // First type of order
        static void MatrixOrderOne(int n)
        {
            int index = 1; // declare some variable that will hold the value of matrix elements
            int[,] matrix = new int[n, n]; // declare matrix
            for (int col = 0; col < matrix.GetLength(1); col++) // begin with columns, not rows, bc we want to declare the elements column by column, not row by row.
            {
                for (int row = 0; row < matrix.GetLength(0); row++) // rows
                {
                    matrix[row, col] = index; // the element is = index
                    index++;                 // then we ++ the index
                }
            }
            MatrixPrint(matrix);          // the printing method, you can see it's code befor main method
        }

        // The second type of order
        static void MatrixOrderTwo(int n)
        {
            int index = 0;
            int secIndex = 0;
            int[,] matrix = new int[n, n];
            for (int col = 0; col < matrix.GetLength(1); col++) // again we begin with columns, and then rows
            {
                
                    if (col % 2 == 0)                       // if the col is even then element get values in order like 1,2,3,4
                    {
                        for (int row = 0; row < matrix.GetLength(0); row++)     
                        {
                            index++;                    // we put the index before the code below, because if we put it below the declarin,
                            matrix[row, col] = index;  // then the odd col will begin not with ex. 8(index+ n), but with 9 (index++) + n
                        }
                    }
                    else                           // else if the row it's NOT even
                    {
                        secIndex = index + n;    // the variable that we will use for the reorederin ex. 8,7,6,5 (secIndex) get the value of index + n
                        index = secIndex;       // here before we begin to -- secIndex, we assign its value to index, so the next even row begin with the appropriate value
                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            matrix[row, col] = secIndex; 
                            secIndex--;         // -- the variable
                        }
                    }
            }
            MatrixPrint(matrix); // printing the matrix
        }

        //The third type of order
        static void MatrixOrderThree(int n)
        {
            int index = 1; // declare some variable that will hold the value of matrix elements
            int[,] matrix = new int[n, n]; // declare matrix

            for (int val = n - 1; val >= 0; val--)      // here we count the number of diagonals, we can make them up to the main diagonal(if n= 4, then with that for we can make 4 diagonals) down - to up
            {
                int x = val;    // coordinat x will always give start of mini diagonals from down to up 
                int y = 0;      // coordinat y will always give start of the mini diagonals, and always it will start from column 0

                while ((x < n) && (y < n)) // the magic :D or until x reach row n, and y reach the last column
                {
                    matrix[x, y] = index++; // asigning values
                    x++;
                    y++;
                }

            }
            int secIndex = n * n;           // for the part above the main diagonal we will begin from the last number(n*n*)
            for (int val = n - 1; val >= 1; val--) 
            {
                int x = (n-1) - val; // here x coord. that give the begin of mini diagonals, have to begin from n - № of the mini diagonal
                int y = n - 1;          // the mini diagonal will always begin from the last column

                while ((x >= 0) && (y > 0)) // until the mini diagonal reach x = 0 and while y is not = to 0
                {
                    matrix[x, y] = secIndex--; // asigning
                    x--;
                    y--;
                }
            }

            MatrixPrint(matrix);          // the printing method, you can see it's code befor main method
        }

        //The fourth type of order
        static void MatrixOrderFour(int n) // My idea is that we run tru the matrix in the form of square (down-right-up-left) 
        {                                   // and when we reach the last number of left part
            int begin = 0;                  // (either limits of matrix or when next el is not 0) 
            int[,] matrix = new int[n, n];  // we go one row down for the next square run with help of directions.

            int row = begin;
            int col = begin;
            int number = 1;
            int direction = 1;

            #region Implementation
            while (number <= n * n)
            {
                if (direction == 1)
                {
                    matrix[row, col] = number;
                    number++;
                    if (row + 1 >= n || matrix[row + 1, col] != 0)
                    {
                        direction = 2;
                    }
                    else
                    {
                        row++;
                    }
                }
                else if (direction == 2)
                {
                    col++;
                    matrix[row, col] = number;
                    number++;
                    if (col + 1 >= n || matrix[row, col + 1] != 0)
                    {
                        direction = 3;
                    }
                }
                else if (direction == 3)
                {
                    row--;
                    matrix[row, col] = number;
                    number++;
                    if (row - 1 < 0 || matrix[row - 1, col] != 0)
                    {
                        direction = 4;
                    }
                }
                else
                {
                    col--;
                    matrix[row, col] = number;
                    number++;
                    if (col - 1 < 0 || matrix[row, col - 1] != 0)
                    {
                        direction = 1;
                        row = row + 1;
                    }
                }
            } 
            #endregion

            MatrixPrint(matrix);

        }

        // Printng current matxrix type
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

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            MatrixOrderOne(n);
            Console.WriteLine();
            MatrixOrderTwo(n);
            Console.WriteLine();
            MatrixOrderThree(n);
            Console.WriteLine();
            MatrixOrderFour(n);
            Console.WriteLine();
            
        }

        
    }
}
