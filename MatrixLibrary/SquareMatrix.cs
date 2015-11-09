using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLibrary
{
    public class SquareMatrix<T>
    {
        protected T[,] square;
        public int Size { get; private set; }
        public AmendMatrixEvent amendEvent = new AmendMatrixEvent();

        public virtual T this[int y, int x]
        {
            get
            {
                if (x >= Size || y >= Size)
                    throw new Exception();
                return square[y, x];
            }
            set
            {
                if( x >= Size || y >= Size)
                    throw new Exception();

                square[y, x] = value;
                amendEvent.OnAmendIMatrixItem(GetMassege(y, x, value));
            }
        }

        public SquareMatrix(T[,] array)
        {
            if (array.GetLength(0) != array.GetLength(1))
                throw new ArgumentException();
            Size = array.GetLength(0);
            square = array;
        }

        internal SquareMatrix(int s)
        {
            Size = s;
            square = new T[s,s];
        }

        public void Print()
        {
            for(int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                    Console.Write( square[i,j] + "\t");
                    
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        protected virtual string GetMassege(int y, int x, T z)
        {
            return string.Format("Изменён элемент [ {0}, {1}] квадратной матрицы на {2}", y, x, z);
        }
    }
}
