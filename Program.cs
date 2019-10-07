using System;

namespace LinkedList
{
    public class MyLinkedList
    {
        internal Node head;

        internal class Node
        {
            internal int data;
            internal Node next;

            // Constructor to create a new node. Next is by default initialized as null
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }
        internal void Insert(int new_data)
        {
            Node new_node = new Node(new_data);

            if (this.head == null)
            {
                this.head = new_node;
                return;
            }
            Node lastNode = GetLastNode(this);

            lastNode.next = new_node;
        }

        internal Node GetLastNode(MyLinkedList list)
        {
            Node temp = list.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        /* This function prints contents of linked list */
        public void PrintList()
        {
            Node n = this.head;

            Console.Write("LinkedList: ");
            while (n != null)
            {
                Console.Write(n.data + " ");
                n = n.next;
            }
        }
        // Main Method 
        public static void Main()
        {
            /* Start with the empty list. */
            MyLinkedList list = new MyLinkedList();

            // Insert the values
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);
            list.Insert(5);
            list.Insert(6);
            list.Insert(7);
            list.Insert(8);

            // Print the LinkedList
            list.PrintList();

        }
    }
}

