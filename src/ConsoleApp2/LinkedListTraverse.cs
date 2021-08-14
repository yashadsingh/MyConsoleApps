using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class LinkedListTraverse
    {

        public class Node
        {
            public int _val { get; set; }
            public Node _next { get; set; }
            public Node(int val)
            {
                _val = val;
            }
        }

        public static void CallMe(int len)
        {
            Node root = null;
            Node temp = null;
            while (len > 0)
            {
                if (root == null)
                {
                    root = new Node(len);
                    temp = root;
                }
                else
                {
                    temp._next = new Node(len);
                    temp = temp._next;
                }
                len--;
            }

            TraverseList(root);

        }


        private static void TraverseList(Node root)
        {
            if (root == null)
                return;

            Console.WriteLine(root._val);
            TraverseList(root._next);
            Console.WriteLine(root._val);

        }

    }

    class RecursionLimit
    {
        public static void CallMe()
        {
            Recur(0);
        }

        private static void Recur(int i)
        {
            Console.WriteLine(i);
            Recur(i + 1);
        }
    }
}
