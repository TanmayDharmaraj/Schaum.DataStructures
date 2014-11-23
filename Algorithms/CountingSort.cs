using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Algorithms
{
    class CountingSort
    {
        public static void Main(string[] args)
        {
            int[] A = new int[6] { 3, 2, 0, 0, 0, 1 };
            SortedDictionary<int, int> dic = new SortedDictionary<int, int>();
            alg_CountingSort(A, dic);
            Console.ReadLine();
        }
        public static void alg_CountingSort(int[] A, SortedDictionary<int, int> dic)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (!dic.ContainsKey(A[i]))
                    dic.Add(A[i], 1);
                else
                    dic[A[i]]++;
            }

            foreach (int i in dic.Keys)
            {
                for (int j = 0; j < dic[i]; j++)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
