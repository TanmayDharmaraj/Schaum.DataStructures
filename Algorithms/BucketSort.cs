using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Algorithms
{
    //bucket sort with has as hash(x) = x/3
    class BucketSort
    {
        private static void Main(string[] args)
        {
            int[] A = new int[8] { 7, 6, 8, 2, 3, 6, 2, 0 };
            //int[,] B = new int[A.Length,];
            ArrayList[] arrList = new ArrayList[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                arrList[i] = new ArrayList();
            }
            for (int i = 0; i < A.Length; i++)
            {
                int index = A[i] / 3;
                int item = A[i];
                arrList[index].Add(item);
            }


            for (int i = 0; i < arrList.Length; i++)
            {
                int[] bucket_one = (int[])arrList[i].ToArray(typeof(int));
                QuickSort(bucket_one, 0, bucket_one.Length - 1);
                foreach (var item in bucket_one)
                {
                    Console.Write(item + " ");
                }
            }
            Console.ReadLine();
        }

        private static void QuickSort(int[] arr, int left, int right)
        {
            if (left >= right) return;
            if (left < right)
            {
                int index = partition(arr, left, right);
                QuickSort(arr, left, index - 1);
                QuickSort(arr, index + 1, right);
            }
        }
        private static int partition(int[] Arr, int left, int right)
        {
            //assume pivot is the right most element
            int pivot = (int)Arr[right];
            int index = left;
            for (int i = left; i < right; i++)
            {
                if ((int)Arr[i] < pivot)
                {
                    int temp = (int)Arr[i];
                    Arr[i] = Arr[index];
                    Arr[index] = temp;
                    index++;
                }
                left++;
            }

            int temp1 = (int)Arr[index];
            Arr[index] = Arr[right];
            Arr[right] = temp1;

            return index;
        }

        private static void swap(ref int val1, ref int val2)
        {
            int temp = val1;
            val1 = val2;
            val2 = temp;
        }

    }
}
