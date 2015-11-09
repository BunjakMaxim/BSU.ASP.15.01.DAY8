using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLibrary
{
    public static class MatrixAdd
    {
        public static void Add<T>(this SquareMatrix<T> matrix1, SquareMatrix<T> matrix2)
        {
            if (matrix1.Size != matrix2.Size)
                throw new Exception();

            for (int i = 0; i < matrix1.Size; i++)
                for (int j = 0; j < matrix1.Size; j++)
                    matrix1[i, j] = (dynamic)matrix1[i, j] + (dynamic)matrix2[i, j];
        }

        public static void Add<T>(this DiagonalMatrix<T> matrix1, DiagonalMatrix<T> matrix2)
        {
            if (matrix1.Size != matrix2.Size)
                throw new Exception();

            for (int i = 0; i < matrix1.Size; i++)
                    matrix1[i, i] = (dynamic)matrix1[i, i] + (dynamic)matrix2[i, i];
        }
    }
}
