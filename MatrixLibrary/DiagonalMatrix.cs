using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLibrary
{
    public class DiagonalMatrix<T> : SquareMatrix<T>
    {
        public DiagonalMatrix(T[] array) : base(array.Length)
        {
            for (int i = 0; i < Size; i++)
                square[i, i] = array[i];
        }

        public override T this[int y, int x]
        {
            get
            {
                return base[y, x];
            }
            set
            {
                if (x != y)
                    throw new Exception();

                base[y, x] = value;
            }
        }

        protected override string GetMassege(int y, int x, T z)
        {
            return string.Format("Изменён элемент [ {0}, {1}] диагональной матрицы на {2}", y, x, z);
        }
    }
}
