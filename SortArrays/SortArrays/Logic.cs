using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrays
{
    public static class Logic
    {
        public static void SortSum(int[][] a) {
            int[] ArraySum = new int[a.GetLength(0)];         
            for (int i = 0; i < a.GetLength(0)-1; i++)
            {
                ArraySum[i] = Sum(a[i]);
            }
           
            for (int i = 0; i < a.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < a.GetLength(0) - i - 1; j++)
                {
                    if (ArraySum[j] > ArraySum[j + 1])
                        Swap(ref a[j], ref a[j + 1]);

                }
            }
        }
        private static int Sum(int[] b)
        {
            int s = 0;

            for (int i = 0; i < b.Length; i++)
            {
                s = s + b[i];
            }
            return s;
        }

        public static void SortMaxElem(int[][] a)
        {
            int[] ArrayMaxElem = new int[a.GetLength(0)];
            for (int i = 0; i < a.GetLength(0) - 1; i++)
            {
                ArrayMaxElem[i] = MaxElem(a[i]);
            }
            for (int i = 0; i < a.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < a.GetLength(0) - i - 1; j++)
                {
                    if (ArrayMaxElem[j] > ArrayMaxElem[j + 1])
                        Swap(ref a[j], ref a[j + 1]);

                }
            }
        }
        private static int MaxElem(int[] b)
        {
            int s = b[0];
            for (int i = 0; i < b.Length; i++)
            {
                if (s < b[i]) s = b[i];
            }
            return s;
        }

        public static void SortMinElem(int[][] a)
        {
            int[] ArrayMinElem = new int[a.GetLength(0)];
            for (int i = 0; i < a.GetLength(0) - 1; i++)
            {
                ArrayMinElem[i] = MinElem(a[i]);
            }

            for (int i = 0; i < a.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < a.GetLength(0) - i - 1; j++)
                {
                    if (ArrayMinElem[j] > ArrayMinElem[j + 1])
                        Swap(ref a[j], ref a[j + 1]);

                }
            }
                     
        }

        private static int MinElem(int[] b)
        {
            int s = b[0];
            for (int i = 0; i < b.Length; i++)
            {
                if (s > b[i]) s = b[i];
            }
            return s;
        }
            
        private static void Swap(ref int[] k, ref int[] l)
        {
            int[] b = k;
            k = l;
            l = b;
        }
    }
}
