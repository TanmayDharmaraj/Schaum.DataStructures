using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7_Trees
{
    class WarshallsAlgorithm
    {
        public static void Main(string[] args)
        {
            //infinity is denoted by -1
            int n = 4,infinity = 99;//set infinity to some number much larger than what is in the array.
            int[,] arr = new int[n, n];
            arr[0, 0] = 7;
            arr[0, 1] = 5;
            arr[0, 2] = 0;
            arr[0, 3] = 0;
            arr[1, 0] = 7;
            arr[1, 1] = 0;
            arr[1, 2] = 0;
            arr[1, 3] = 2;
            arr[2, 0] = 0;
            arr[2, 1] = 3;
            arr[2, 2] = 0;
            arr[2, 3] = 0;
            arr[3, 0] = 4;
            arr[3, 1] = 0;
            arr[3, 2] = 1;
            arr[3, 3] = 0;

            //sets all zeros to -1
            init(arr,infinity);

            WarshallShortestPath(arr);
            int count = arr.GetLength(0);
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }

        private static void init(int[,] arr,int infinity)
        {
            int count = arr.GetLength(0);
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    if (arr[i, j] == 0)
                    {
                        arr[i, j] = infinity;
                    }
                }
            }
        }

        private static void WarshallShortestPath(int[,] array)
        {
            int k = 0;
            
            int count = array.GetLength(0);
            while (k < count)
            {
                Console.WriteLine("Computing k = " + k);
                for (int i = 0; i < count; i++)
                {
                    for (int j = 0; j < count; j++)
                    {
                        array[i, j] = Math.Min(array[i, j], (array[i, k] + array[k, j]));
                    }
                }
                k++;
            }
        }
    }
}
