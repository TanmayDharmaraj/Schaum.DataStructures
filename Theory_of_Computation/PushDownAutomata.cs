using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory_of_Computation
{
    class PushDownAutomata
    {

        //test if the brackets are balanced. ((()))
        static void Main(string[] args)
        {
            Console.WriteLine("Implementation of Push Down Automata to check if the brackets are balanced.");
            Console.WriteLine("Please input brackets. Press spacebar to test");
            Stack<char> stack = new Stack<char>();
            ConsoleKey cki = ConsoleKey.Enter;
            while (cki != ConsoleKey.Spacebar)
            {
                cki = Console.ReadKey().Key;
                Console.WriteLine("");
                if (cki == ConsoleKey.D0)
                {
                    stack.Pop();
                }
                else if (cki == ConsoleKey.D9)
                {
                    stack.Push('d'); 
                }
            }
            if (stack.Count == 0)
            {
                Console.WriteLine("The brackets are balanced");
            }
            else
            {
                Console.WriteLine("The brackets are not balanced");
            }
            Console.ReadLine();
        }
    }
}
