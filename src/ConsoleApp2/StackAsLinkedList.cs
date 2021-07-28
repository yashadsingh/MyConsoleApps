using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    public class StackAsLinkedList
    {
        int size = 0;
        Node top;
        Node root;

        public class Node
        {
            public Node(dynamic value)
            {
                _value = value;
            }

            public dynamic _value;
            public Node _lastNode;
        }

        public void Push(dynamic newValue)
        {
            if (root == null)
            {
                root = new Node(newValue);
                top = root;
                size = 1;
            }
            else
            {
                var newItem = new Node(newValue);
                newItem._lastNode = top;
                top = newItem;
                size++;
            }
        }

        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            else
            {
                var popItem = top;
                top = top._lastNode;
                size--;
                popItem = null;
            }
        }

        public Node Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return null;
            }
            else
            {
                return top;
            }
        }

        public bool IsEmpty()
        {
            return (top == null);
        }

        public static void CallMe()
        {
            StackAsLinkedList stackAsLinkedList = new StackAsLinkedList();
            Console.WriteLine($"Step 1 stackAsLinkedList.IsEmpty(): {stackAsLinkedList.IsEmpty()}");

            stackAsLinkedList.Push(1);
            Console.WriteLine($"Step 2 Added 1 in stackAsLinkedList so size is now: {stackAsLinkedList.size}");

            stackAsLinkedList.Push("John Wik");
            Console.WriteLine($"Step 3 Added 'John Wik' as string in stackAsLinkedList so size is now: {stackAsLinkedList.size}");

            stackAsLinkedList.Push(1.00001f);
            Console.WriteLine($"Step 4 Added 1.00001 as float in stackAsLinkedList so size is now: {stackAsLinkedList.size}");

            Console.WriteLine($"Step 5 Peek in stackAsLinkedList so value is: {stackAsLinkedList.Peek()._value}");

            stackAsLinkedList.Pop();
            Console.WriteLine($"Step 6 Pop from stackAsLinkedList so size is now: {stackAsLinkedList.size}");

            Console.WriteLine($"Step 7 Peek in stackAsLinkedList so value is: {stackAsLinkedList.Peek()._value}");

            Node startTraverse = stackAsLinkedList.top;
            Console.WriteLine($"Iterate items in stackAsLinkedList of size: {stackAsLinkedList.size}");
            while (startTraverse != null)
            {
                Console.WriteLine($"{startTraverse._value}");
                startTraverse = startTraverse._lastNode;
            }
        }
    }

}
