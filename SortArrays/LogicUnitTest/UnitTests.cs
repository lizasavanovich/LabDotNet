using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortArrays;


namespace LogicUnitTest
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestSortSumStr()
        {
            int[][] A = new int[3][];
            A[0] = new int[] { 1, 3, 5 };
            A[1] = new int[] { 9, 10 };
            A[2] = new int[] { 0, 2, 4, 6 };

            int[][] B = new int[3][];
            B[0] = new int[] { 1, 3, 5 };
            B[1] = new int[] { 0, 2, 4, 6 };
            B[2] = new int[] { 9, 10 };

            Logic.SortSum(A);

            int n = 0;

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A[i].Length; j++)
                {
                    if (A[i][j] != B[i][j])
                    {
                        n = 1;
                    }
                }
            }

            Assert.AreEqual(0, n);
        }

       [TestMethod]
        public void TestSortMaxElem()
        {
            int[][] A = new int[3][];
            A[0] = new int[] { 1, 3, 5 };
            A[1] = new int[] { 9, 10 };
            A[2] = new int[] { 0, 2, 4, 6 };

            int[][] B = new int[3][];
            B[0] = new int[] { 1, 3, 5 };
            B[1] = new int[] { 0, 2, 4, 6 };
            B[2] = new int[] { 9, 10 };

            Logic.SortMaxElem(A);

            int n = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A[i].Length; j++)
                {
                    if (A[i][j] != B[i][j])
                    {
                        n = 1;
                    }
                }
            }

            Assert.AreEqual(0, n);
        }
    
     [TestMethod]
        public void TestSortMinElem()
        {
            int[][] A = new int[3][];
            A[0] = new int[] { 9, 10 };
            A[1] = new int[] { 1, 3, 5 };
            A[2] = new int[] { 0, 2, 4, 6 };

            int[][] B = new int[3][];
            B[0] = new int[] { 0, 2, 4, 6 };
            B[1] = new int[] { 1, 3, 5 };
            B[2] = new int[] { 9, 10 };

            Logic.SortMinElem(A);

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A[i].Length; j++)
                {
                    Console.WriteLine(A[i][j]);
                }
            }

            int n = 0;

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A[i].Length; j++)
                {
                    if (A[i][j] != B[i][j])
                    {
                        n = 1;
                    }
                }
            }

            Assert.AreEqual(0, n);
            }
}

}