using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class InsertionSort
    {
        static void Main(string[] args)
        {
            int[] A = new int[5] { 7, 8, 1, 2, 3 };
            for (int i = 1; i < A.Length; i++)
            {
                alg_InsertionSort(A, i, A[i]);
            }

            foreach (int i in A)
            {
                Console.Write(i+ " ");
            }
            Console.ReadLine();
        }
        private static void alg_InsertionSort(int[] A, int position, int value)
        {
            int i = position - 1;
            while (i >= 0 && A[i] >= value)
            {
                A[i + 1] = A[i];
                i--;
            }
            A[i + 1] = value;
        }
    }
}
