using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class MedianSort
    {
        private static void Main(string[] args)
        {
            int[] A = new int[2] { 8, 7};
            alg_MedianSort(A, 0, A.Length-1);
            foreach (int i in A)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }


        private static void alg_MedianSort(int[] A, int left, int right)
        {
            
            if (left < right)
            {

                int mid = (right - left+1) / 2;
                //assume median is always first element = left
                swap(A, mid, left);
                for (int i = left; i <= mid-1; i++)
                {
                    if (A[i] > A[mid])
                    {
                        for (int j = mid+1; j <= right; j++)
                        {
                            if (A[j] <= A[mid])
                            {
                                swap(A, i, j);
                                break;
                            }
                        }
                    }
                }
                alg_MedianSort(A, left, left+mid - 1);
                alg_MedianSort(A, left+mid + 1, right);
            }
        }

        private static void swap(int[] A, int position1, int position2)
        {
            int temp = A[position1];
            A[position1] = A[position2];
            A[position2] = temp;
        }
    }


}
