using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixLibrary;

namespace MatrixConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Диагональная матрица");
            DiagonalMatrix<int> diagonalInt = new DiagonalMatrix<int>(new int[] { 1, 2, 3, 4 });
            diagonalInt.Print();
            diagonalInt.amendEvent.amendIMatrixItem += (s, e) => Console.WriteLine(e.massage);
            diagonalInt[2, 2] = 5;
            diagonalInt.Print();

            Console.WriteLine("Симметрическая матрица");
            SymmetricMatrix<int> symmetricInt = new SymmetricMatrix<int>(new int[][]
                {
                   new int[] {1,2,3,4},
                   new int[] {  2,3,4},
                   new int[] {    3,4},
                   new int[] {      4}
                });
            symmetricInt.Print();
            symmetricInt.amendEvent.amendIMatrixItem += (s, e) => Console.WriteLine(e.massage);
            symmetricInt[1, 3] = 9;
            symmetricInt.Print();

            Console.WriteLine("Квадратная матрица");
            SquareMatrix<int> square = new SquareMatrix<int>(new int[,]
                {
                    {1,1,1,1},
                    {2,2,2,2},
                    {3,3,3,3},
                    {4,4,4,4}
                });
            square.Print();
            square.amendEvent.amendIMatrixItem += (s, e) => Console.WriteLine(e.massage);
            square[2, 2] = 10;
            square.Print();

            Console.WriteLine("Квадратная + Симметрическая");
            square.Add(symmetricInt);
            square.Print();

            Console.ReadKey();
        }
    }
}
