using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6_Stacks_Queues_Recursion
{
    class Tower_of_Hanoi
    {
        private static void init(Stack<int> A, int n)
        {
            for (int i = 0; i < n; i++)
            {
                A.Push(i);
            }
        }
        static void Main(string[] args)
        {
            Stack<int> A = new Stack<int>();
            Stack<int> B = new Stack<int>();
            Stack<int> C = new Stack<int>();

            init(A, 5);
            int count = 5;
            Console.WriteLine("Solving Hanoi...");
            SolveHanoi(A, B, C);
            Console.WriteLine("C");
            while (count != 0)
            {
                Console.WriteLine("{0}",C.Pop());
                count--;
            }
            Console.ReadLine();
        }

        private static void SolveHanoi(Stack<int> A, Stack<int> B, Stack<int> C)
        {
            int count=A.Count;
            for (int i = 0; i <= count-2; i++)
            {
                B.Push(A.Pop());
            }
            C.Push(A.Pop());
            for (int i = 0; i < count-1; i++)
            {
                C.Push(B.Pop());
            }
        }
    }
}
