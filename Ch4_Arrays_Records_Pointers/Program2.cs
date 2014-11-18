using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_Arrays_Records_Pointers
{
    class Program2
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 16, -6, 7 };
            int[] B = new int[] { 4, 2, -3 };
            int X = 2, Y = -5;
            MatrixMul_4_44(A, B, X, Y);


            int[,] A1 = new int[2, 3] { { 4, -3, 5 }, { 6, 1, -2 } };
            int[,] B1 = new int[3, 4] { { 2, 3, -7, -3 }, { 5, -1, 6, 2 }, { 0, 3, -2, 1 } };
            int[,] C1 = new int[2, 4];
            MatrixMul_4_45(A1, B1, out C1, 2, 3, 4);

            Horners(new int[] { 5, -6, 7, 8,-9 }, 2);

            Console.ReadLine();//MatrixMul_4_45()
        }

        static void MatrixMul_4_44(int[] A, int[] B, int X, int Y)
        {
            int[] result = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                result[i] = A[i] * X + B[i] * Y;
            }
            foreach (int item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }
        static void MatrixMul_4_45(int[,] A, int[,] B, out int[,] C1, int M, int P, int N)
        {

            C1 = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                    for (int k = 0; k < P; k++)
                        C1[i, j] = C1[i, j] + (A[i, k] * B[k, j]);

            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(C1[i, j] + "  ");
                }
                Console.WriteLine();
            }

        }

        static void Horners(int[] coeff, int x)
        {
            int result = 0;
            for (int i = 0; i < coeff.Length - 1; i++)
            {
                result = (result + coeff[i]) * x;
            }
            result = coeff[coeff.Length - 1] + result;
            Console.WriteLine(result);
            
        }

        
    }
}
