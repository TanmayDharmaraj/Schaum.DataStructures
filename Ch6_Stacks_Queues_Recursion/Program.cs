using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6_Stacks_Queues_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] obj = new object[] { 44, 33, 11, 55, 77, 90, 40, 60, 99, 22, 88, 66 };
            //object[] obj = new object[] { 7, 2, 1, 6, 8, 5, 3, 4 };
            QucikSort(obj, 0, 11);



            for (int i = 0; i < obj.Length; i++)
            {
                Console.WriteLine(i + ") " + obj[i]);
            }
            Console.ReadLine();
        }

        static void QucikSort(object[] A, int left, int right)
        {
            if (left >= right) return;
            if (left < right)
            {
                int pIndex = Partition(A, left, right);
                QucikSort(A, left, pIndex- 1);
                QucikSort(A, pIndex + 1, right);

            }
        }

        private static int Partition(object[] A, int left, int right)
        {
            int pivot = (int)A[right];
            int index = left;
            for (int i = left; i < right; i++)
            {
                if ((int)A[i] <= pivot)
                {
                    int temp = (int)A[i];
                    A[i] = A[index];
                    A[index] = temp;
                    index++;
                }
            }
            //swap one last time
            int t = (int)A[index];
            A[index] = A[right];
            A[right] = t;

            return index;
        }
    }
}
