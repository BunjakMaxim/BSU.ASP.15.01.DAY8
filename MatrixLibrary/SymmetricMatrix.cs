using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLibrary
{
    public class SymmetricMatrix<T> : SquareMatrix<T>
    {
        public SymmetricMatrix(T[][] array)
            : base(array.Length)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i].Length != array.Length - i)
                    throw new ArgumentException();


                for (int j = 0; j < array[i].Length; j++)
                {
                    square[i, j + i] = array[i][j];
                    square[j + i, i] = array[i][j];
                }
            }
        }

        public SymmetricMatrix(T[,] array)
            : base(array.GetLength(0))
        {
            if (array.GetLength(0) != array.GetLength(1))
                throw new ArgumentException();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = i; j < array.GetLength(2); j++)
                {
                    if (array[i,j].Equals(array[j,i]))
                        throw new ArgumentException();

                    square[i, j] = array[i,j];
                    square[j, i] = array[i,j];
                }
            }
        }

        public override T this[int y, int x]
        {
            get
            {
                return base[y, x];
            }
            set
            {
                base[y, x] = value;
                base[x, y] = value;
            }
        }

        protected override string GetMassege(int y, int x, T z)
        {
            return string.Format("Изменён элемент [ {0}, {1}] диагональной матрицы на {2}", y, x, z);
        }
    }
}
