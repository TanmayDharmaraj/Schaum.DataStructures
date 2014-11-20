using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7_Trees
{
    class BinaryTree
    {
        public class Node
        {
            public object content;
            public Node left;
            public Node right;
        }
        private Node head, current;
        public BinaryTree()
        {
            head = null;
        }
        public void add(object content)
        {
            var n = new Node()
            {
                content = content,
                left = null,
                right = null
            };
            if (head == null)
            {
                head = n;
            }
            else if ((int)content > (int)head.left.content)
            {
                
            }
            else if ((int)content > (int)head.left.content)
            {

            }

            current = n;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree bt = new BinaryTree();
            bt.add(5);
            bt.add(2);
            bt.add(1);
            bt.add(3);

        }
    }
}
