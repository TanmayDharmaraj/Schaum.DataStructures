using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_LinkedList
{

    public class List
    {

        public class Node
        {
            public object NodeContent;
            public Node Next;
        }

        private int size;
        public int Count
        {
            get
            {
                return size;
            }
        }

        private Node head;

        private Node current;

        public List()
        {
            size = 0;
            head = null;
        }


        public void Add(object content)
        {
            size++;

            var node = new Node()
            {
                NodeContent = content
            };

            if (head == null)
            {
                head = node;
            }
            else
            {
                current.Next = node;
            }

            current = node;
        }

        public void ListNodes()
        {
            Node tempNode = head;

            while (tempNode != null)
            {
                Console.WriteLine(tempNode.NodeContent);
                tempNode = tempNode.Next;
            }
        }

        public Node Retrieve(int Position)
        {
            Node tempNode = head;
            Node retNode = null;
            int count = 0;

            while (tempNode != null)
            {
                if (count == Position - 1)
                {
                    retNode = tempNode;
                    break;
                }
                count++;
                tempNode = tempNode.Next;
            }

            return retNode;
        }

        public int Max()
        {
            Node temp = head;
            int greatest = (int)temp.NodeContent;
            while (temp.Next != null)//we have items inside linked list
            {
                if (greatest < (int)temp.Next.NodeContent)
                {
                    greatest = (int)temp.Next.NodeContent;

                }
                temp = temp.Next;
            }
            return greatest;
        }

        public int Mean()
        {
            Node temp = head;
            int total = 0;
            while (temp != null)
            {
                total += (int)temp.NodeContent;
                temp = temp.Next;
            }
            if (total > 0)
                return total / size;
            else
                return 0;
        }
        public int Prod()
        {
            Node temp = head;
            if (temp.Next == null) { return (int)temp.NodeContent; }
            int total = 1;
            while (temp != null)
            {
                total = total * (int)temp.NodeContent;
                temp = temp.Next;
            }
            if (total > 0)
                return total;
            else
                return 0;
        }


        public bool Delete(int Position)
        {
            if (Position == 1)
            {
                head = null;
                current = null;
                return true;
            }

            if (Position > 1 && Position <= size)
            {
                Node tempNode = head;

                Node lastNode = null;
                int count = 0;

                while (tempNode != null)
                {
                    if (count == Position - 1)
                    {
                        lastNode.Next = tempNode.Next;
                        return true;
                    }
                    count++;
                    lastNode = tempNode;
                    tempNode = tempNode.Next;
                }
            }

            return false;
        }

        public void MoveFirstToLast()
        {

            Node t = head.Next;
            current.Next = head;
            head.Next = null;
            head = t;
        }

        public void Swap(int k)
        {
            if (k == size) return;

            int count = 1;
            Node temp = head;
            Node prev = head;
            while (temp != null)
            {
                if (k == 1)
                {
                    Node y = head.Next;
                    head.Next = temp.Next.Next;
                    y.Next = head;
                    head = y;
                    break;
                }
                if (count == k)
                {
                    Node k_ = temp;
                    Node k_plus_2 = temp.Next.Next;
                    Node k_plus_1 = temp.Next;

                    prev.Next = k_plus_1;
                    temp.Next = k_plus_2;
                    k_plus_1.Next = k_;

                    break;
                }
                prev = temp;
                temp = temp.Next;
                count++;
            }
        }

        public void Sort()
        {

            Node temp = head;
            Node first = head;

            for (int i = 0; i <= size; i++)
            {
                for (int j = 0; j <= size - 1; j++)
                {
                    if (temp != null && temp.Next != null)
                    {
                        if ((int)temp.NodeContent > (int)temp.Next.NodeContent)
                        {
                            Swap(j);
                        }
                        temp = temp.Next;
                    }
                   else break;
                }

            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List l = new List();
            l.Add(7);
            l.Add(1);
            l.Add(4);
            l.Add(5);
            l.Add(2);
            l.Add(3);
            l.Add(6);


            //l.Swap(7);
            //l.ListNodes();
            
            /***still not complete. Find a way to crack this.***/
            l.Sort();
            l.ListNodes();
            /*
            l.MoveFirstToLast();
            l.ListNodes();
            l.Swap(2);
            l.ListNodes();



            Console.WriteLine(l.Max());
            Console.WriteLine(l.Mean());
            Console.WriteLine(l.Prod());
            Console.WriteLine("Delete item 2:" + l.Delete(2));
            Console.WriteLine("List is now ");
            l.ListNodes();
            */
            Console.ReadLine();


        }
    }
}
