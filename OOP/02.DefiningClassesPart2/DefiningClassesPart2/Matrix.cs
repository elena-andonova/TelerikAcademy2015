using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
//    Problem 8. Matrix
//    Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).

//Problem 9. Matrix indexer
//    Implement an indexer this[row, col] to access the inner matrix cells.

//Problem 10. Matrix operations
//    Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication.
//    Throw an exception when the operation cannot be performed.
//    Implement the true operator (check for non-zero elements).

    class Matrix<T>
    {
        private T[,] matrixElements;
        private uint rows;
        private uint columns;

        public Matrix(uint rows, uint columns)
        {
            this.Rows = rows;
            this.Columns = columns;
            this.matrixElements = new T[this.Rows, this.Columns];
        }

        public uint Rows
        {
            get { return this.rows; }
            private set { this.rows = value; }
        }
        public uint Columns
        {
            get { return this.columns; }
            private set { this.columns = value; }
        }

        public T this[int row, int col]
        {
            get
            {
                if ((row >= 0 && row <= this.Rows - 1) && (col >= 0 && col <= this.Columns - 1))
                {
                    return this.matrixElements[row, col];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if ((row >= 0 && row <= this.Rows - 1) && (col >= 0 && col <= this.Columns - 1))
                {
                    this.matrixElements[row, col] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public static Matrix<T> operator +(Matrix<T> Matrix1, Matrix<T> Matrix2)
        {
            if (Matrix1.Rows == Matrix2.Rows && Matrix1.Columns == Matrix2.Columns)
            {
                Matrix<T> Matrix3 = new Matrix<T>(Matrix1.Rows, Matrix1.Columns);
                for (int i = 0; i < Matrix1.Rows; i++)
                {
                    for (int j = 0; j < Matrix1.Columns; j++)
                    {
                        Matrix3[i, j] = (dynamic)Matrix1[i, j] + (dynamic)Matrix2[i, j];
                    }
                }
                return Matrix3;
            }
            else
            {
                throw new IndexOutOfRangeException("Rows and columns of both matrices must be equal!");
            }
        }

        public static Matrix<T> operator -(Matrix<T> Matrix1, Matrix<T> Matrix2)
        {
            if (Matrix1.Rows == Matrix2.Rows && Matrix1.Columns == Matrix2.Columns)
            {
                Matrix<T> Matrix3 = new Matrix<T>(Matrix1.Rows, Matrix1.Columns);
                for (int i = 0; i < Matrix1.Rows; i++)
                {
                    for (int j = 0; j < Matrix1.Columns; j++)
                    {
                        Matrix3[i, j] = (dynamic)Matrix1[i, j] - (dynamic)Matrix2[i, j];
                    }
                }
                return Matrix3;
            }
            else
            {
                throw new IndexOutOfRangeException("Rows and columns of both matrices must be equal!");
            }
        }

        public static Matrix<T> operator *(Matrix<T> Matrix1, Matrix<T> Matrix2)
        {
            if (Matrix1.Rows == Matrix2.Columns)
            {
                Matrix<T> Matrix3 = new Matrix<T>(Matrix1.Rows, Matrix1.Columns);
                for (int i = 0; i < Matrix3.Rows; i++)
                {
                    for (int j = 0; j < Matrix3.Columns; j++)
                    {
                        for (int k = 0; k < Matrix1.Rows; k++)
                        {
                            Matrix3[i, j] += (dynamic)Matrix1[i, k] * (dynamic)Matrix2[k, j];
                        }
                    }
                }
                return Matrix3;
            }
            else
            {
                throw new IndexOutOfRangeException("Rows of the first matrix and columns of the second matrix must to be equal!");
            }
        }

        public static bool operator true(Matrix<T> Matrix)
        {
            return BooleanOperator(Matrix, true);
        }
        public static bool operator false(Matrix<T> Matrix)
        {
            return BooleanOperator(Matrix, false);
        }
        private static bool BooleanOperator(Matrix<T> Matrix, bool trueFalse)
        {
            foreach (var element in Matrix.matrixElements)
            {
                if (!element.Equals(default(T)))
                {
                    return trueFalse;
                }
            }
            return !trueFalse;
        }
    }
}
