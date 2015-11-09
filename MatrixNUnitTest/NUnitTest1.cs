using System;
using MatrixLibrary;
using NUnit.Framework;

namespace MatrixNUnitTest
{
    [TestFixture]
    public class NUnitTest1
    {
        [Test]
        public void TestAddDouble()
        {
            double[,] m = 
            {
                {0.1, 0.2, 0.3},
                {0.2, 0.3, 0.4},
                {0.3, 0.4, 0.5}
            };
            double[] m2 = { 0.3, 0.4, 0.5};

            SquareMatrix<double> matr1 = new SquareMatrix<double>(m);
            matr1.Add(new DiagonalMatrix<double>(m2));

            double[,] rezult = 
            {
                {0.4, 0.2, 0.3},
                {0.2, 0.7, 0.4},
                {0.3, 0.4, 1.0}
            };
            for(int i = 0; i < 3; i++)
                for(int j = 0; j < 3 ; j++)
                    Assert.AreEqual(matr1[i,j], rezult[i,j]);
        }


        [Test]
        public void TestAddInt()
        {
            int[,] m = 
            {
                {1, 0, 2, 3},
                {2, 0, 3, 4},
                {3, 0, 4, 5},
                {4, 0, 5, 6}
            };
            int[] m2 = { 0, 3, 4, 4};

            SquareMatrix<int> matr1 = new SquareMatrix<int>(m);
            matr1.Add(new DiagonalMatrix<int>(m2));

            int[,] rezult = 
            {
                {1, 0, 2, 3},
                {2, 3, 3, 4},
                {3, 0, 8, 5},
                {4, 0, 5, 10}
            };
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    Assert.AreEqual(matr1[i, j], rezult[i, j]);
        }
    }
}