namespace Deffining_Classes_2.Matrix
{
    using System;
    using System.Collections.Generic;

    // TASK 8
    class Matrix<T> where T: struct, IComparable
    {
        private T[,] matrix;
        public int Row { get; private set; }
        public int Col { get; private set; }

        public Matrix(int row, int col)
        {
            this.matrix = new T[row, col];
        }

        public Matrix(T[,] matrix)
        {
            this.matrix = matrix;
            this.Row = this.matrix.GetLength(0);
            this.Col = this.matrix.GetLength(1);
        }

        public T[,] MatrixOfElements
        {
            get
            {
                return this.matrix;
            }
            set
            {
                this.matrix = value;
            }
        }

        // TASK 9
        public T this[int row, int col]
        {
            get
            {
                if ((row < 0 || col < 0) || (row >= this.matrix.GetLength(0) || col >= this.matrix.GetLength(1)))
                {
                    throw new IndexOutOfRangeException();
                }

                return this.matrix[row, col];
            }
            set
            {
                if ((row < 0 || col < 0) || (row >= this.matrix.GetLength(0) || col >= this.matrix.GetLength(1)))
                {
                    throw new IndexOutOfRangeException();
                }

                this.matrix[row, col] = value;
            }
        }

        // TASK 10
        public static Matrix<T> operator +(Matrix<T> A, Matrix<T> B)
        {
            if (A.Row != B.Row || A.Col != B.Col)
            {
                throw new ArgumentException("Matrixes have to be with same count of rows and cols!");
            }
            else
            {
                Matrix<T> output = new Matrix<T>(A.Row, A.Col);

                for (int row = 0; row < A.Row; row++)
                {
                    for (int col = 0; col < A.Col; col++)
                    {
                        output[row, col] = (dynamic)A[row, col] + B[row, col];
                    }
                }

                return output;
            }
        }

        public static Matrix<T> operator -(Matrix<T> A, Matrix<T> B)
        {
            if (A.Row != B.Row || A.Col != B.Col)
            {
                throw new ArgumentException("Matrixes have to be with same count of rows and cols!");
            }
            else
            {
                Matrix<T> output = new Matrix<T>(A.Row, A.Col);

                for (int row = 0; row < A.Row; row++)
                {
                    for (int col = 0; col < A.Col; col++)
                    {
                        output[row, col] = (dynamic)A[row, col] + (-1 * (dynamic)B[row, col]);
                    }
                }

                return output;
            }
        }

        public static Matrix<T> operator *(Matrix<T> A, Matrix<T> B)
        {
            Matrix<T> output = new Matrix<T>(A.Row, A.Col);

            for (int row = 0; row < A.Row; row++)
            {
                for (int col = 0; col < A.Col; col++)
                {
                    for (int incol = 0, inrow = 0; incol < A.Col; incol++, inrow++)
                    {
                        output[row, col] += (dynamic)A[row, incol] * B[inrow,col];
                        
                    }
                }
            }

            return output;
        }

        public static bool operator true(Matrix<T> A)
        {
            for (int row = 0; row < A.Row; row++)
            {
                for (int col = 0; col < A.Col; col++)
                {
                    if (A[row, col].Equals(0))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool operator false(Matrix<T> A)
        {
            for (int row = 0; row < A.Row; row++)
            {
                for (int col = 0; col < A.Col; col++)
                {
                    if (!(A[row, col].Equals(0)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
